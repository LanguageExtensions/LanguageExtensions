﻿using LanguageExtensions.Specifications;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess.MongoDb
{
    public class MongoDbRepository<TEntity, TKey> :
        MongoDbRepository<TEntity>,
        ICommandRepository<TEntity, TKey>,
        IQueryRepository<TEntity, TKey>
            where TEntity : class
    {
        #region Constructor

        public MongoDbRepository(IMongoClient mongoClient, string dbName, Expression<Func<TEntity, TKey>> primaryKeySelector)
            : base(mongoClient, dbName)
        {
            PrimaryKeySelector = primaryKeySelector;
        }

        #endregion

        #region IGetRepository Implementation

        public async Task<TEntity> GetAsync(TKey key)
        {
            var predicate = Builders<TEntity>.Filter.Where(this.GetPrimaryKeySpecification(key));
            return await GetCollection().Find(predicate).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<TEntity>> GetManyAsync(IEnumerable<TKey> keys)
        {
            var predicate = Builders<TEntity>.Filter.Where(this.GetPrimaryKeySpecification(keys));
            return await GetCollection().Find(predicate).ToListAsync();
        }

        #endregion

        #region IRepositoryWithKey Implementation

        public Expression<Func<TEntity, TKey>> PrimaryKeySelector { get; }

        #endregion

        #region IInsertRepository

        public async Task<TKey> AddAsync(TEntity entity)
        {
            await GetCollection().InsertOneAsync(entity);
            return this.GetPrimaryKey(entity);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
            => await GetCollection().InsertManyAsync(entities);

        #endregion

        #region IUpdateRepository

        public async Task UpdateAsync(TEntity entity)
        {
            var filter = Builders<TEntity>.Filter.Eq(PrimaryKeySelector, this.GetPrimaryKey(entity));
            await GetCollection().ReplaceOneAsync(filter, entity);
        }

        #endregion
    }

    public class MongoDbRepository<TEntity> : 
        IQueryRepository<TEntity>
            where TEntity : class
    {
        #region private fields

        protected IMongoDatabase _database;
        protected readonly string _collectionName;

        #endregion

        #region Constructor

        public MongoDbRepository(IMongoClient mongoClient, string dbName)
        {
            _database = mongoClient.GetDatabase(dbName);
            _collectionName = typeof(TEntity).Name;
        }

        #endregion

        #region Virtual Extension points

        protected virtual string GetCollectionName() => _collectionName;

        #endregion

        #region Private Helper methods

        protected IMongoCollection<TEntity> GetCollection() => _database.GetCollection<TEntity>(GetCollectionName());
        private FilterDefinition<TEntity> GetFilter(Specification<TEntity> specification) => Builders<TEntity>.Filter.Where(specification);

        #endregion

        #region IFindRepository Implementation

        public async Task<bool> AnyAsync(Specification<TEntity> specification)
        {
            if (specification.IsTrue()) return true;
            if (specification.IsFalse()) return false;

            return await GetCollection().Find(GetFilter(specification)).AnyAsync();
        }

        public async Task<IReadOnlyList<TResult>> WhereAsync<TResult>(
            Specification<TEntity> specification,
            IQueryOptions<TEntity> queryOptions,
            Expression<Func<TEntity, TResult>> selector)
        {
            if (specification.IsFalse()) return Enumerable.Empty<TResult>().ToList();

            IQueryable<TEntity> filteredResults = specification.IsTrue() ? GetCollection().AsQueryable() : GetCollection().AsQueryable().Where(specification);

            return await Task.Run(() =>
                                filteredResults
                                .Apply(queryOptions)
                                .Select(selector).ToList());
        }

        #endregion

        #region IAggregateRepository Implementation

        public async Task<long> CountAsync(Specification<TEntity> specification)
        {
            if (specification.IsTrue()) return await GetCollection().EstimatedDocumentCountAsync();
            if (specification.IsFalse()) return 0;

            return await GetCollection().CountDocumentsAsync(GetFilter(specification));
        }

        #endregion

        #region IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing) return;
            if (_database == null) return;
            _database = null;
        }

        #endregion
    }
}

using LanguageExtensions.DataAccess.Abstractions;
using LanguageExtensions.Specifications;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess.MongoDb
{
    public class MongoDbRepository<TEntity, TKey> :
        MongoDbRepository<TEntity>,
        IGetRepository<TEntity, TKey>,
        IRepositoryWithKey<TEntity, TKey>
            where TEntity : class
    {
        #region Constructor

        public MongoDbRepository(IMongoClient mongoClient, string dbName, Expression<Func<TEntity, TKey>> primaryKeySelector)
            :base(mongoClient, dbName)
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
    }

    public class MongoDbRepository<TEntity>
        : IFindRepository<TEntity>
            where TEntity : class
    {
        #region private fields

        protected readonly IMongoDatabase _database;
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

        #endregion

        #region IFindRepository Implementation

        public async Task<TEntity> FindAsync(Specification<TEntity> specification)
        {
            var predicate = Builders<TEntity>.Filter.Where(specification);
            return await GetCollection().Find(predicate).FirstOrDefaultAsync();
        }

        #endregion
    }
}

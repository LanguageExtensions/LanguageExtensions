using LanguageExtensions.DataAccess.Abstractions;
using LanguageExtensions.Specifications;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess.MongoDb
{
    public class MongoDbRepository<TEntity, TKey> : IGetRepository<TEntity, TKey>
    {
        private readonly IMongoDatabase _database;
        private readonly string _collectionName;
        private readonly Expression<Func<TEntity, TKey>> _primaryKeySelector;

        public MongoDbRepository(IMongoClient mongoClient, string dbName, Expression<Func<TEntity, TKey>> primaryKeySelector)
        {
            _database = mongoClient.GetDatabase(dbName);
            _collectionName = typeof(TEntity).Name;
            _primaryKeySelector = primaryKeySelector;
        }

        private IMongoCollection<TEntity> GetCollection() => _database.GetCollection<TEntity>(GetCollectionName());

        protected virtual string GetCollectionName() => _collectionName;
        #region IGetRepository Implementation

        public async Task<TEntity> GetAsync(TKey key)
        {
            var predicate = Builders<TEntity>.Filter.Eq(_primaryKeySelector, key);
            return await GetCollection().Find(predicate).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<TEntity>> GetManyAsync(IEnumerable<TKey> keys)
        {
            var spec = keys.Select(GetPrimaryKeySpecification)
                .Aggregate((left, right) => left.Or(right));
            var predicate = Builders<TEntity>.Filter.Where(spec);
            return await GetCollection().Find(predicate).ToListAsync();
        }

        #endregion
        #region Private Helper Methods

        private Specification<TEntity> GetPrimaryKeySpecification(TKey key)
            => new PropertySpecification<TEntity, TKey>(_primaryKeySelector, key);

        #endregion
    }
}

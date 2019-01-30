using LanguageExtensions.DataAccess.Abstractions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess.MongoDb
{
    public class MongoDbCurdRepository<T, TKey> : ICurdRepository<T, TKey>
    {
        public Task<TKey> AddAsync(T entity) => throw new NotImplementedException();
        public Task<IEnumerable<TKey>> AddManyAsync(IEnumerable<T> entities) => throw new NotImplementedException();
        public Task<T> GetAsync(TKey key) => throw new NotImplementedException();
        public Task<IEnumerable<T>> GetManyAsync(params TKey[] keys) => throw new NotImplementedException();
        public Task<IEnumerable<T>> GetManyAsync(IEnumerable<TKey> keys) => throw new NotImplementedException();
    }
}

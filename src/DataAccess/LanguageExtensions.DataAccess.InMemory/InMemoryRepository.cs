using LanguageExtensions.DataAccess.Abstractions;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using LanguageExtensions.Specifications;

namespace LanguageExtensions.DataAccess.InMemory
{
    public class InMemoryRepository<TEntity, TKey> : IGetRepository<TEntity, TKey>
    {
        #region private fields

        private readonly Expression<Func<TEntity, TKey>> _primaryKeySelector;
        private readonly List<TEntity> _seedData;

        #endregion
        
        #region Constructor

        public InMemoryRepository(Expression<Func<TEntity, TKey>> primaryKeySelector, IEnumerable<TEntity> seedData)
        {
            _primaryKeySelector = primaryKeySelector;
            _seedData = seedData.ToList();
        }

        public InMemoryRepository(Expression<Func<TEntity, TKey>> primaryKeySelector)
            : this(primaryKeySelector, new List<TEntity>())
        { }

        #endregion

        #region IInsertRepository Implementation

        public Task<TKey> AddAsync(TEntity entity) => throw new NotImplementedException();
        public Task<IEnumerable<TKey>> AddManyAsync(IEnumerable<TEntity> entities) => throw new NotImplementedException();

        #endregion

        #region IGetRepository Implementation

        public async Task<TEntity> GetAsync(TKey key)
            => _seedData.FirstOrDefault(GetPrimaryKeySpecification(key));

        public async Task<IEnumerable<TEntity>> GetManyAsync(params TKey[] keys)
            => await GetManyAsync(keys.ToList());

        public async Task<IEnumerable<TEntity>> GetManyAsync(IEnumerable<TKey> keys)
        {
            var spec = keys.Select(GetPrimaryKeySpecification)
                .Aggregate((left, right) => left.Or(right));
            return _seedData.Where(spec).ToList();
        }

        #endregion
        
        #region Private Helper Methods

        private Specification<TEntity> GetPrimaryKeySpecification(TKey key)
            => new PropertySpecification<TEntity, TKey>(_primaryKeySelector, key);

        #endregion
    }
}

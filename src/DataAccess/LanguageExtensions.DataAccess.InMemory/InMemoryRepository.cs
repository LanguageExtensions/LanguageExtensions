using LanguageExtensions.DataAccess.Abstractions;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using LanguageExtensions.Specifications;

namespace LanguageExtensions.DataAccess.InMemory
{
    public class InMemoryRepository<TEntity, TKey> : 
        IGetRepository<TEntity, TKey>, 
        IRepositoryWithKey<TEntity, TKey>
            where TEntity : class
    {
        #region private fields

        private readonly List<TEntity> _seedData;

        #endregion

        #region Constructor

        public InMemoryRepository(Expression<Func<TEntity, TKey>> primaryKeySelector, IEnumerable<TEntity> seedData)
        {
            PrimaryKeySelector = primaryKeySelector;
            _seedData = seedData.ToList();
        }

        public InMemoryRepository(Expression<Func<TEntity, TKey>> primaryKeySelector)
            : this(primaryKeySelector, new List<TEntity>())
        { }

        #endregion

        #region IGetRepository Implementation

        public Task<TEntity> GetAsync(TKey key)
            => Task.FromResult(_seedData.FirstOrDefault(this.GetPrimaryKeySpecification(key)));

        public Task<IEnumerable<TEntity>> GetManyAsync(IEnumerable<TKey> keys)
            => Task.FromResult<IEnumerable<TEntity>>(_seedData.Where(this.GetPrimaryKeySpecification(keys)).ToList());

        #endregion

        #region IRepositoryWithKey Implementation

        public Expression<Func<TEntity, TKey>> PrimaryKeySelector { get; }

        #endregion
    }
}

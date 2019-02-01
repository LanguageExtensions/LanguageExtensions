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
        InMemoryRepository<TEntity>,
        IGetRepository<TEntity, TKey>,
        IRepositoryWithKey<TEntity, TKey>
            where TEntity : class
    {
        #region Constructor

        public InMemoryRepository(Expression<Func<TEntity, TKey>> primaryKeySelector, IEnumerable<TEntity> seedData) : base(seedData)
        {
            PrimaryKeySelector = primaryKeySelector;
        }

        public InMemoryRepository(Expression<Func<TEntity, TKey>> primaryKeySelector)
            : this(primaryKeySelector, new List<TEntity>())
        { }

        #endregion

        #region IGetRepository Implementation

        public Task<TEntity> GetAsync(TKey key)
            => Task.FromResult(_seedData.FirstOrDefault(this.GetPrimaryKeySpecification(key).IsSatisfiedBy));

        public Task<IEnumerable<TEntity>> GetManyAsync(IEnumerable<TKey> keys)
            => Task.FromResult<IEnumerable<TEntity>>(_seedData.Where(this.GetPrimaryKeySpecification(keys).IsSatisfiedBy).ToList());

        #endregion

        #region IRepositoryWithKey Implementation

        public Expression<Func<TEntity, TKey>> PrimaryKeySelector { get; }

        #endregion
    }

    public class InMemoryRepository<TEntity> : IFindRepository<TEntity>
            where TEntity : class
    {
        #region private fields

        protected readonly List<TEntity> _seedData;

        #endregion

        #region Constructor

        public InMemoryRepository(IEnumerable<TEntity> seedData)
        {
            _seedData = seedData.ToList();
        }

        #endregion

        #region IFindRepository Implementation

        public Task<TEntity> FindAsync(Specification<TEntity> specification) => Task.FromResult(_seedData.FirstOrDefault(specification.IsSatisfiedBy));

        #endregion
    }
}

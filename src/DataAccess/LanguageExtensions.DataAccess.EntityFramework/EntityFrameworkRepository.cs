using LanguageExtensions.DataAccess.Abstractions;
using LanguageExtensions.Specifications;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess.EntityFramework
{
    public class EntityFrameworkRepository<TEntity, TKey> :
        EntityFrameworkRepository<TEntity>,
        IGetRepository<TEntity, TKey>,
        IRepositoryWithKey<TEntity, TKey>
            where TEntity : class
    {
        #region Constructor

        public EntityFrameworkRepository(DbContext dbContext, Expression<Func<TEntity, TKey>> primaryKeySelector)
            : base(dbContext)
        {
            PrimaryKeySelector = primaryKeySelector;
        }

        #endregion

        #region IRepositoryWithKey Implementation

        public Expression<Func<TEntity, TKey>> PrimaryKeySelector { get; }

        #endregion

        #region IGetRepository Implementation

        public async Task<TEntity> GetAsync(TKey key)
        {
            var spec = this.GetPrimaryKeySpecification(key);
            return await _dbSet.FirstOrDefaultAsync(spec);
        }

        public async Task<IEnumerable<TEntity>> GetManyAsync(IEnumerable<TKey> keys)
        {
            var spec = this.GetPrimaryKeySpecification(keys);
            return await _dbSet.Where(spec).ToListAsync();
        }

        #endregion
    }

    public class EntityFrameworkRepository<TEntity>
        : IFindRepository<TEntity>
            where TEntity : class
    {
        #region protected Fields

        protected readonly IDbSet<TEntity> _dbSet;
        protected readonly DbContext _dbContext;

        #endregion

        #region Constructor

        public EntityFrameworkRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        #endregion

        #region IFindRepository Implementation

        public async Task<TEntity> FindAsync(Specification<TEntity> specification) 
            => await _dbSet.FirstOrDefaultAsync(specification);

        #endregion
    }
}

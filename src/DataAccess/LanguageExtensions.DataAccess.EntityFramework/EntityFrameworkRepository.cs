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
        IGetRepository<TEntity, TKey>,
        IRepositoryWithKey<TEntity, TKey>
            where TEntity : class
    {
        private readonly IDbSet<TEntity> _dbSet;
        private readonly DbContext _dbContext;
        
        #region Constructor

        public EntityFrameworkRepository(DbContext dbContext, Expression<Func<TEntity, TKey>> primaryKeySelector)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
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
}

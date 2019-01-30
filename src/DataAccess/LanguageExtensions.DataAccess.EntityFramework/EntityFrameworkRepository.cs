using LanguageExtensions.DataAccess.Abstractions;
using LanguageExtensions.Specifications;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess.EntityFramework
{
    public class EntityFrameworkRepository<TEntity, TKey> : IGetRepository<TEntity, TKey> where TEntity : class
    {
        private readonly IDbSet<TEntity> _dbSet;
        private readonly DbContext _dbContext;
        private readonly Expression<Func<TEntity, TKey>> _primaryKeySelector;

        public EntityFrameworkRepository(DbContext dbContext, Expression<Func<TEntity, TKey>> primaryKeySelector)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
            _primaryKeySelector = primaryKeySelector;
        }

        public async Task<TEntity> GetAsync(TKey key)
        {
            var spec = GetPrimaryKeySpecification(key);
            return await _dbSet.FirstOrDefaultAsync();
        }

        public Task<IEnumerable<TEntity>> GetManyAsync(IEnumerable<TKey> keys) => throw new NotImplementedException();

        #region Private Helper Methods

        private Specification<TEntity> GetPrimaryKeySpecification(TKey key)
            => new PropertySpecification<TEntity, TKey>(_primaryKeySelector, key);

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess.Abstractions
{
    public interface IInsertRepository<TEntity, TKey> :
        IRepositoryWithKey<TEntity, TKey>,
        IDisposable
            where TEntity : class
    {
        /// <summary>
        /// Adds the specified entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        Task<TKey> AddAsync(TEntity entity);

        /// <summary>
        /// Adds the specified entities.
        /// </summary>
        /// <param name="entities">The entities.</param>
        Task AddRangeAsync(IEnumerable<TEntity> entities);
    }
}

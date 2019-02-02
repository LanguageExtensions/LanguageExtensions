using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess.Abstractions
{
    public interface IInsertRepository<TEntity, TKey> : IDisposable
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
        Task<IEnumerable<TKey>> AddManyAsync(IEnumerable<TEntity> entities);
    }
}

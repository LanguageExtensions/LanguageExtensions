using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess
{
    public interface IGetRepository<TEntity, TKey> : IDisposable
        where TEntity : class
    {
        /// <summary>
        /// Gets the specified entity of type <typeparamref name="TEntity"/> from the repository by the primary key.
        /// </summary>
        /// <param name="key">The primary key.</param>
        /// <returns>The entity that matches on the primary key</returns>
        Task<TEntity> GetAsync(TKey key);

        /// <summary>
        /// Gets the specified entity of type <typeparamref name="TEntity"/> from the repository by the primary key.
        /// </summary>
        /// <param name="keys">The primary keys.</param>
        /// <returns>The entity that matches on the primary key</returns>
        Task<IEnumerable<TEntity>> GetManyAsync(IEnumerable<TKey> keys);
    }
}

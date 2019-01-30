using System.Collections.Generic;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess.Abstractions
{
    public interface IGetRepository<T, TKey>
    {
        /// <summary>
        /// Gets the specified entity of type <typeparamref name="T"/> from the repository by the primary key.
        /// </summary>
        /// <param name="key">The primary key.</param>
        /// <returns>The entity that matches on the primary key</returns>
        Task<T> GetAsync(TKey key);

        /// <summary>
        /// Gets the specified entity of type <typeparamref name="T"/> from the repository by the primary key.
        /// </summary>
        /// <param name="keys">The primary keys.</param>
        /// <returns>The entity that matches on the primary key</returns>
        Task<IEnumerable<T>> GetManyAsync(params TKey[] keys);

        /// <summary>
        /// Gets the specified entity of type <typeparamref name="T"/> from the repository by the primary key.
        /// </summary>
        /// <param name="keys">The primary keys.</param>
        /// <returns>The entity that matches on the primary key</returns>
        Task<IEnumerable<T>> GetManyAsync(IEnumerable<TKey> keys);
    }
}

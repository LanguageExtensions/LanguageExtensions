using System;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess.Abstractions
{
    public interface IUpdateRepository<TEntity, TKey> :
        IRepositoryWithKey<TEntity, TKey>,
        IDisposable
            where TEntity : class
    {
        /// <summary>
        /// Update the provided entity.
        /// </summary>
        /// <param name="entity">The entity.</param>
        Task UpdateAsync(TEntity entity);
    }
}

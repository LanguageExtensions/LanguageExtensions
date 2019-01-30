using System;
using System.Linq.Expressions;

namespace LanguageExtensions.DataAccess.Abstractions
{
    public interface IRepositoryWithKey<T, TKey>
    {
        /// <summary>
        /// Returns the Type for the entity of this repository.
        /// </summary>
        Type EntityType { get; }

        /// <summary>
        /// Returns the Type for the key of this repository.
        /// </summary>
        Type KeyType { get; }

        Expression<Func<T, bool>> GetSelector(params TKey[] keys);
    }
}

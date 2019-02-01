using LanguageExtensions.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace LanguageExtensions.DataAccess.Abstractions
{
    public interface IRepositoryWithKey<TEntity, TKey>
        where TEntity : class
    {
        Expression<Func<TEntity, TKey>> PrimaryKeySelector { get; }
    }

    public static class REpositoryWithKeyExtensions
    {
        public static Specification<TEntity> GetPrimaryKeySpecification<TEntity, TKey>(this IRepositoryWithKey<TEntity, TKey> repository, TKey key)
            where TEntity : class 
                => new PropertySpecification<TEntity, TKey>(repository.PrimaryKeySelector, key);
        public static Specification<TEntity> GetPrimaryKeySpecification<TEntity, TKey>(
            this IRepositoryWithKey<TEntity, TKey> repository, 
            IEnumerable<TKey> keys)
                where TEntity : class
                    => keys.Select(key => repository.GetPrimaryKeySpecification(key))
                        .Aggregate((left, right) => left.Or(right));
    }
}

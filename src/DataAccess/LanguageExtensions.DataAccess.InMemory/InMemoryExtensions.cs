using LanguageExtensions.DataAccess;
using System;
using System.Linq.Expressions;
using System.Reflection;

namespace LanguageExtensions.DataAccess.InMemory
{
    public static class InMemoryExtensions
    {
        public static TEntity SetPrimaryKey<TEntity, TKey>(
            this IRepositoryWithKey<TEntity, TKey> repository,
            TEntity entity,
            TKey key)
                where TEntity : class
        {
            entity.SetPropertyValue(repository.PrimaryKeySelector, key);
            return entity;
        }

        public static T SetPropertyValue<T, TValue>(this T target, Expression<Func<T, TValue>> memberLamda, TValue value)
        {
            var memberSelectorExpression = memberLamda.Body as MemberExpression;
            var property = memberSelectorExpression?.Member as PropertyInfo;
            property?.SetValue(target, value, null);
            return target;
        }
    }
}

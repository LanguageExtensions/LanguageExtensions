using LanguageExtensions.Specifications;
using System;
using System.Linq.Expressions;
using System.Reflection;

namespace LanguageExtensions.DataAccess.Abstractions.Specifications
{
    internal class PropertySpecification<TEntity, TKey> : Specification<TEntity>
    {
        Lazy<Expression<Func<TEntity, bool>>> _lazySpecification;
        private readonly Expression<Func<TEntity, TKey>> _propertySelector;
        private readonly TKey _key;

        public PropertySpecification(Expression<Func<TEntity, TKey>> propertySelector, TKey key)
        {
            _propertySelector = propertySelector;
            _key = key;
            _lazySpecification = new Lazy<Expression<Func<TEntity, bool>>>(GetPrimaryKeyPredicate);
        }

        private Expression<Func<TEntity, bool>> GetPrimaryKeyPredicate()
        {
            MemberExpression member = _propertySelector.Body as MemberExpression;
            PropertyInfo propInfo = member.Member as PropertyInfo;

            var parameter = Expression.Parameter(typeof(TEntity), "x");
            var lambda = Expression.Lambda<Func<TEntity, bool>>(
                    Expression.Equal(
                        Expression.PropertyOrField(parameter, propInfo.Name),
                        Expression.Constant(_key)
                    ),
                    parameter
                );
            return lambda;
        }

        public override Expression<Func<TEntity, bool>> ToExpression() => _lazySpecification.Value;
    }
}

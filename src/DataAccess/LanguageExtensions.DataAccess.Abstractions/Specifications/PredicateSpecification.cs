using LanguageExtensions.Specifications;
using System;
using System.Linq.Expressions;

namespace LanguageExtensions.DataAccess.Specifications
{
    internal class PredicateSpecification<T> : Specification<T>
    {
        private readonly Expression<Func<T, bool>> _predicate;

        public PredicateSpecification(Expression<Func<T, bool>> predicate) => _predicate = predicate;

        public override Expression<Func<T, bool>> ToExpression() => _predicate;
    }
    public static class SpecificationExtensionsExpressions
    {
        public static Specification<TEntity> ToSpecification<TEntity>(this Expression<Func<TEntity, bool>> predicate)
            => new PredicateSpecification<TEntity>(predicate);
    }
}

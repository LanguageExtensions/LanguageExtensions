using System;
using System.Linq.Expressions;

namespace LanguageExtensions.Specifications
{
    internal sealed class TrueSpecification<T> : Specification<T>
    {
        public override Expression<Func<T, bool>> ToExpression() => x => true;
    }

    internal sealed class FalseSpecification<T> : Specification<T>
    {
        public override Expression<Func<T, bool>> ToExpression() => x => false;
    }
}

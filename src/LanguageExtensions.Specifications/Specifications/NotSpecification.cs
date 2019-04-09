using System;
using System.Linq.Expressions;

namespace LanguageExtensions.Specifications
{
    internal class NotSpecification<T> : Specification<T>
    {
        private Specification<T> _inner;

        internal NotSpecification(Specification<T> inner)
            => _inner = inner ?? throw new ArgumentNullException("inner");

        public override Expression<Func<T, bool>> ToExpression() 
            => _inner.ToExpression().Not();
    }
}

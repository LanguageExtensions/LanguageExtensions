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
        {
            if (_inner.IsTrue()) return False;
            if (_inner.IsFalse()) return True;

            return _inner.ToExpression().Not();
        }
    }
}

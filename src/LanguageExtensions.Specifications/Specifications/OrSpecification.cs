using System;
using System.Linq.Expressions;

namespace LanguageExtensions.Specifications
{
    internal class OrSpecification<T> : Specification<T>
    {
        private Specification<T> _left;
        private Specification<T> _right;

        internal OrSpecification(Specification<T> left, Specification<T> right)
        {
            _left = left ?? throw new ArgumentNullException("left");
            _right = right ?? throw new ArgumentNullException("right");
        }

        public override Expression<Func<T, bool>> ToExpression()
            => _left.ToExpression().Or(_right.ToExpression());
    }
}

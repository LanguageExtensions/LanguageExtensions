using System;
using System.Linq;
using System.Linq.Expressions;

namespace LanguageExtensions.Specifications
{
    internal class AndSpecification<T> : Specification<T>
    {
        private Specification<T> _left;
        private Specification<T> _right;

        internal AndSpecification(Specification<T> left, Specification<T> right)
        {
            _left = left ?? throw new ArgumentNullException("left");
            _right = right ?? throw new ArgumentNullException("right");
        }

        public override Expression<Func<T, bool>> ToExpression() 
            => _left.IsFalse() || _right.IsFalse() 
                ? False 
                : _left.ToExpression().And(_right.ToExpression());
    }
}

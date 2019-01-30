using System;
using System.Linq;
using System.Collections.Generic;
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
            => _left.ToExpression().And(_right.ToExpression());
    }

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
            => _left.ToExpression().And(_right.ToExpression());
    }

    internal class NotSpecification<T> : Specification<T>
    {
        private Specification<T> _inner;

        internal NotSpecification(Specification<T> inner)
            => _inner = inner ?? throw new ArgumentNullException("inner");

        public override Expression<Func<T, bool>> ToExpression()
            => _inner.ToExpression().Not();
    }

    internal class AllSpecification<T> : Specification<T>
    {
        private readonly IEnumerable<Specification<T>> _specs;

        internal AllSpecification(IEnumerable<Specification<T>> specs) => _specs = specs ?? throw new ArgumentNullException("specs");

        public override Expression<Func<T, bool>> ToExpression() => _specs.Aggregate((s1, s2) => s1.And(s2)).ToExpression();
    }

    internal class AnySpecification<T> : Specification<T>
    {
        private readonly IEnumerable<Specification<T>> _specs;

        internal AnySpecification(IEnumerable<Specification<T>> specs) => _specs = specs ?? throw new ArgumentNullException("specs");

        public override Expression<Func<T, bool>> ToExpression() => _specs.Aggregate((s1, s2) => s1.Or(s2)).ToExpression();
    }
}

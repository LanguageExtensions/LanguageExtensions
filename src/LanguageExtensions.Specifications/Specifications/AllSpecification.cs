using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LanguageExtensions.Specifications
{
    internal sealed class AllSpecification<T> : Specification<T>
    {
        private readonly IEnumerable<Specification<T>> _specs;

        internal AllSpecification(IEnumerable<Specification<T>> specs) => _specs = specs ?? throw new ArgumentNullException("specs");

        public override Expression<Func<T, bool>> ToExpression()
            => _specs.Any(s => s.IsFalse())
                ? False
                : _specs.Aggregate((s1, s2) => s1.And(s2)).ToExpression();
    }
}

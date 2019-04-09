using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LanguageExtensions.Specifications
{
    internal class AnySpecification<T> : Specification<T>
    {
        private readonly IEnumerable<Specification<T>> _specs;

        internal AnySpecification(IEnumerable<Specification<T>> specs) => _specs = specs ?? throw new ArgumentNullException("specs");

        public override Expression<Func<T, bool>> ToExpression() 
            => _specs.Aggregate((s1, s2) => s1.Or(s2)).ToExpression();
    }
}

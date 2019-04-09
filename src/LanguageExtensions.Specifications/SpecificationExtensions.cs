using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace LanguageExtensions.Specifications
{
    /// <summary>
    /// Extensions that facilitates the usage of ISpecifications.
    /// </summary>
    public static class SpecificationExtensions
    {
        /// <summary>
        /// Checks if a certain candidate meets a given specification.
        /// </summary>
        /// <param name="candidate"></param>
        /// <returns>New specification</returns>
        public static bool Is<TEntity>(this TEntity candidate, Specification<TEntity> spec) => spec.IsSatisfiedBy(candidate);

        /// <summary>
        /// Composes two ISpecifications using an And operator.
        /// </summary>
        /// <typeparam name="T">Candidate type</typeparam>
        /// <param name="spec1"></param>
        /// <param name="spec2"></param>
        /// <returns></returns>
        public static Specification<TEntity> And<TEntity>(this Specification<TEntity> spec1, Specification<TEntity> spec2)
        {
            if (spec1.IsTrue() && spec2.IsTrue()) return Specification<TEntity>.True;
            if (spec1.IsFalse() || spec2.IsFalse()) return Specification<TEntity>.False;
            return new AndSpecification<TEntity>(spec1, spec2);
        }

        /// <summary>
        /// Composes two ISpecifications using an Or operator.
        /// </summary>
        /// <typeparam name="T">Candidate type</typeparam>
        /// <param name="spec1"></param>
        /// <param name="spec2"></param>
        /// <returns></returns>
        public static Specification<TEntity> Or<TEntity>(this Specification<TEntity> spec1, Specification<TEntity> spec2)
        {
            if (spec1.IsTrue() || spec2.IsTrue()) return Specification<TEntity>.True;
            if (spec1.IsFalse() && spec2.IsFalse()) return Specification<TEntity>.False;
            return new OrSpecification<TEntity>(spec1, spec2);
        }

        /// <summary>
        /// Negates an ISpecification.
        /// </summary>
        /// <typeparam name="T">Candidate type</typeparam>
        /// <param name="spec">Inner specification</param>
        /// <returns></returns>
        public static Specification<TEntity> Not<TEntity>(this Specification<TEntity> spec)
        {
            if(spec.IsTrue()) return Specification<TEntity>.False;
            if(spec.IsFalse()) return Specification<TEntity>.True;
            return new NotSpecification<TEntity>(spec);
        }

        /// <summary>
        /// Composes many ISpecifications using an And operator.
        /// </summary>
        /// <typeparam name="T">Candidate type</typeparam>
        /// <param name="specs"></param>
        /// <returns></returns>
        public static Specification<TEntity> All<TEntity>(this IEnumerable<Specification<TEntity>> specs)
        {
            if (System.Linq.Enumerable.All(specs, spec => spec.IsTrue())) return Specification<TEntity>.True;
            if (System.Linq.Enumerable.Any(specs, spec => spec.IsFalse())) return Specification<TEntity>.False;
            return new AllSpecification<TEntity>(specs);
        }

        /// <summary>
        /// Composes many ISpecifications using an And operator.
        /// </summary>
        /// <typeparam name="T">Candidate type</typeparam>
        /// <param name="specs"></param>
        /// <returns></returns>
        public static Specification<TEntity> Any<TEntity>(this IEnumerable<Specification<TEntity>> specs)
        {
            if (System.Linq.Enumerable.Any(specs, spec => spec.IsTrue())) return Specification<TEntity>.True;
            if (System.Linq.Enumerable.All(specs, spec => spec.IsFalse())) return Specification<TEntity>.False;

            return new AnySpecification<TEntity>(specs);
        }

        public static bool IsTrue<T>(this Specification<T> spec) => spec is TrueSpecification<T>;
        public static bool IsFalse<T>(this Specification<T> spec) => spec is FalseSpecification<T>;
    }

}

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
        public static Specification<TEntity> And<TEntity>(this Specification<TEntity> spec1, Specification<TEntity> spec2) => new AndSpecification<TEntity>(spec1, spec2);

        /// <summary>
        /// Composes two ISpecifications using an Or operator.
        /// </summary>
        /// <typeparam name="T">Candidate type</typeparam>
        /// <param name="spec1"></param>
        /// <param name="spec2"></param>
        /// <returns></returns>
        public static Specification<TEntity> Or<TEntity>(this Specification<TEntity> spec1, Specification<TEntity> spec2) => new OrSpecification<TEntity>(spec1, spec2);

        /// <summary>
        /// Negates an ISpecification.
        /// </summary>
        /// <typeparam name="T">Candidate type</typeparam>
        /// <param name="spec">Inner specification</param>
        /// <returns></returns>
        public static Specification<TEntity> Not<TEntity>(this Specification<TEntity> spec) => new NotSpecification<TEntity>(spec);

        /// <summary>
        /// Composes many ISpecifications using an And operator.
        /// </summary>
        /// <typeparam name="T">Candidate type</typeparam>
        /// <param name="specs"></param>
        /// <returns></returns>
        public static Specification<TEntity> All<TEntity>(this IEnumerable<Specification<TEntity>> specs) => new AllSpecification<TEntity>(specs);

        /// <summary>
        /// Composes many ISpecifications using an And operator.
        /// </summary>
        /// <typeparam name="T">Candidate type</typeparam>
        /// <param name="specs"></param>
        /// <returns></returns>
        public static Specification<TEntity> Any<TEntity>(this IEnumerable<Specification<TEntity>> specs) => new AnySpecification<TEntity>(specs);

        internal static bool IsTrue<T>(this Specification<T> spec) => spec is TrueSpecification<T>;
        internal static bool IsFalse<T>(this Specification<T> spec) => spec is FalseSpecification<T>;
    }

}

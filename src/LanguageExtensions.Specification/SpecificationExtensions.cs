using System.Collections.Generic;

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
        public static bool Is<T>(this T candidate, Specification<T> spec) => spec.IsSatisfiedBy(candidate);
        
        /// <summary>
        /// Composes two ISpecifications using an And operator.
        /// </summary>
        /// <typeparam name="T">Candidate type</typeparam>
        /// <param name="spec1"></param>
        /// <param name="spec2"></param>
        /// <returns></returns>
        public static Specification<T> And<T>(this Specification<T> spec1, Specification<T> spec2) => new AndSpecification<T>(spec1, spec2);

        /// <summary>
        /// Composes two ISpecifications using an Or operator.
        /// </summary>
        /// <typeparam name="T">Candidate type</typeparam>
        /// <param name="spec1"></param>
        /// <param name="spec2"></param>
        /// <returns></returns>
        public static Specification<T> Or<T>(this Specification<T> spec1, Specification<T> spec2) => new OrSpecification<T>(spec1, spec2);

        /// <summary>
        /// Negates an ISpecification.
        /// </summary>
        /// <typeparam name="T">Candidate type</typeparam>
        /// <param name="spec">Inner specification</param>
        /// <returns></returns>
        public static Specification<T> Not<T>(this Specification<T> spec) => new NotSpecification<T>(spec);

        /// <summary>
        /// Composes many ISpecifications using an And operator.
        /// </summary>
        /// <typeparam name="T">Candidate type</typeparam>
        /// <param name="specs"></param>
        /// <returns></returns>
        public static Specification<T> All<T>(this IEnumerable<Specification<T>> specs) => new AllSpecification<T>(specs);

        /// <summary>
        /// Composes many ISpecifications using an And operator.
        /// </summary>
        /// <typeparam name="T">Candidate type</typeparam>
        /// <param name="specs"></param>
        /// <returns></returns>
        public static Specification<T> Any<T>(this IEnumerable<Specification<T>> specs) => new AnySpecification<T>(specs);
    }
}

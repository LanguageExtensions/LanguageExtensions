﻿using System;
using System.Linq.Expressions;

namespace LanguageExtensions.Specifications
{
    public abstract class Specification<T>
    {
        /// <summary>
        /// Checks if a certain candidate meets a given specification.
        /// </summary>
        /// <param name="candidate"></param>
        /// <returns>New specification</returns>
        public virtual bool IsSatisfiedBy(T candidate)
        {
            return ToExpression().Compile()(candidate);
        }

        /// <summary>
        /// Expression that defines the specification.
        /// </summary>
        public abstract Expression<Func<T, bool>> ToExpression();

        /// <summary>
        /// Allows to combine two query specifications using a logical AND operation.
        /// </summary>
        public static Specification<T> operator &(Specification<T> spec1, Specification<T> spec2) => new AndSpecification<T>(spec1, spec2);

        /// <summary>
        /// Allows to combine two query specifications using a logical OR operation.
        /// </summary>
        public static Specification<T> operator |(Specification<T> spec1, Specification<T> spec2) => new OrSpecification<T>(spec1, spec2);

        /// <summary>
        /// Negates the given specification.
        /// </summary>
        public static Specification<T> operator !(Specification<T> spec) => new NotSpecification<T>(spec);

        /// <summary>
        /// Combines a specification with a boolean value. 
        /// The candidate meets the criteria only when the boolean is true.
        /// </summary>
        /// <param name="value">Boolean value</param>
        /// <param name="spec">Specification</param>
        /// <returns>New specification</returns>
        public static Specification<T> operator ==(bool value, Specification<T> spec) => value ? spec : !spec;

        /// <summary>
        /// Combines a specification with a boolean value. 
        /// The candidate meets the criteria only when the boolean is true.
        /// </summary>
        /// <param name="value">Boolean value</param>
        /// <param name="spec">Specification</param>
        /// <returns>New specification</returns>
        public static Specification<T> operator ==(Specification<T> spec, bool value) => value ? spec : !spec;

        /// <summary>
        /// Combines a specification with a boolean value. 
        /// The candidate meets the criteria only when the boolean is false.
        /// </summary>
        /// <param name="value">Boolean value</param>
        /// <param name="spec">Specification</param>
        /// <returns>New specification</returns>
        public static Specification<T> operator !=(bool value, Specification<T> spec) => value ? !spec : spec;

        /// <summary>
        /// Combines a specification with a boolean value. 
        /// The candidate meets the criteria only when the boolean is false.
        /// </summary>
        /// <param name="value">Boolean value</param>
        /// <param name="spec">Specification</param>
        /// <returns>New specification</returns>
        public static Specification<T> operator !=(Specification<T> spec, bool value) => value ? !spec : spec;

        /// <summary>
        /// Allows using Specification[T] in place of a lambda expression.
        /// </summary>
        /// <param name="spec"></param>
        public static implicit operator Expression<Func<T, bool>>(Specification<T> spec) => spec.ToExpression();

        /// <summary>
        /// Allows using Specification[T] in place of Func[T, bool].
        /// </summary>
        /// <param name="spec"></param>
        public static explicit operator Func<T, bool>(Specification<T> spec) => spec.IsSatisfiedBy;

        public static explicit operator Specification<T>(Expression<Func<T, bool>> predicate) => new PredicateSpecification<T>(predicate);
    }
}

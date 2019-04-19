using System;

namespace LanguageExtensions.Functional
{
    public abstract class Result<T> : MayBe<T>
    {
        public bool IsSuccess { get => HasValue; }
        public bool IsFailure { get => this is Error<T>; }

        public static implicit operator Result<T>(Exception ex) =>
            new Error<T>(ex);

        public static implicit operator Result<T>(T obj) =>
            obj != null ? (Result<T>)new Some<T>(obj) : new None<T>();

        public static implicit operator Result<T>(None obj)
            => new None<T>();

        public static implicit operator Result<T>(Try<T> @try)
            => @try.Try();

        public Result<T> OnException<TException>(T mapValue)
            where TException : Exception
                => this is Error<T> exceptionResult && ((Exception)exceptionResult) is TException
                ? mapValue
                : this;

        public Result<T> OnException<TException>(Func<TException, T> mapValue)
            where TException : Exception
                => this is Error<T> exceptionResult && ((Exception)exceptionResult) is TException expectedException
                ? mapValue(expectedException)
                : this;
    }
}

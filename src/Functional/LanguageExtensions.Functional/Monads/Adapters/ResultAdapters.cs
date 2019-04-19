using System;

namespace LanguageExtensions.Functional
{
    public static class ResultAdapters
    {
        public static Result<T> OnSuccess<T>(this Result<T> source, Action<T> toDo)
        {
            if (source is Some<T> result)
                toDo(result);
            return source;
        }

        public static TResult Reduce<TResult>(
            this Result<TResult> result,
            TResult whenNoneOrFaulted) =>
                result is Error<TResult> || result is None<TResult>
                    ? whenNoneOrFaulted
                    : (Some<TResult>)result;

        public static Result<TResult> OnException<TResult>(
            this Result<TResult> result,
                TResult mapValue,
                Func<Exception, bool> when) =>
                    result is Error<TResult> exceptionResult && when(exceptionResult)
                        ? mapValue
                        : result;

        public static Result<TResult> OnException<TResult>(
            this Result<TResult> result,
                Func<Exception, TResult> mapValue,
                Func<Exception, bool> when) =>
                    result is Error<TResult> exceptionResult && when(exceptionResult)
                        ? mapValue(exceptionResult)
                        : result;

        public static Result<TResult> OnNone<TResult>(
            this Result<TResult> result,
                TResult mapValue)
                    => result is None<TResult> exceptionResult
                        ? mapValue
                        : result;

        public static Result<TOut> Map<TIn, TOut>(
            this Result<TIn> source,
            Func<TIn, TOut> map)
        {
            switch (source)
            {
                case Error<TIn> ex: return (Result<TOut>)(Exception)ex;
                case Some<TIn> val: return map(val);
                case None<TIn> _:
                default:
                    return new None<TOut>();
            }
        }
    }
}

using System;

namespace LanguageExtensions.Functional
{
    public static class MayBeAdapters
    {
        public static MayBe<TResult> Map<T, TResult>(
            this MayBe<T> option,
            Func<T, TResult> map)
                => option is Some<T> some ? (MayBe<TResult>)map(some) : None.Value;

        public static MayBe<T> When<T>(
            this T value,
            Func<T, bool> predicate)
                => predicate(value) ? (MayBe<T>)value : None.Value;

        public static T Reduce<T>(
            this MayBe<T> option,
            T whenNone)
                => option is Some<T> some ? (T)some : whenNone;

        public static T Reduce<T>(
            this MayBe<T> option,
            Func<T> whenNone)
                => option is Some<T> some ? (T)some : whenNone();

        public static MayBe<T> AsOption<T>(this T input)
            => (MayBe<T>)input;

        public static Result<T> ToResult<T>(
            this MayBe<T> option)
        {
            switch (option)
            {
                case Some<T> val: return (Result<T>)(T)val;
                case None<T> _:
                default:
                    return new None<T>();
            }
        }
    }
}

using System;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;

namespace LanguageExtensions.Functional
{
    public static class TryAdapters
    {
        [Pure]
        public static Try<A> AsTry<A>(this A v) =>
            () => v;

        public static TryAsync<A> ToAsync<A>(this Try<A> self) => () => Task.FromResult(self.Try());

        public static Result<T> Try<T>(this Try<T> self)
        {
            if (self == null) return None.Value;

            try
            {
                return self();
            }
            catch (Exception e)
            {
                return e;
            }
        }

        public static Try<A> Memoize<A>(this Try<A> ma)
        {
            Lazy<Result<A>> result = new Lazy<Result<A>>(() => ma.Try());
            return new Try<A>(() => result.Value);
        }

        [Pure]
        public static Try<B> Map<A, B>(this Try<A> self, Func<A, B> f) =>
            Memoize(() => self.Try().Map(f));

        [Pure]
        public static Try<T> Then<T>(this Try<T> self, Action<T> f) =>
            Memoize(() =>
            {
                Result<T> result = self.Try();

                if (result is Some<T> val) f(val);

                return result;
            });
    }
}

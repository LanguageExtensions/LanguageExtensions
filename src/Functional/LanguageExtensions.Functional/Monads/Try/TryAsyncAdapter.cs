using System;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;

namespace LanguageExtensions.Functional
{
    public static class TryAsyncAdapter
    {
        [Pure]
        public static TryAsync<A> AsTryAsync<A>(this A v) =>
            () => Task.FromResult<Result<A>>(v);

        public static TryAsync<A> Memoize<A>(this TryAsync<A> ma)
        {
            Lazy<Task<Result<A>>> result = new Lazy<Task<Result<A>>>(() => ma.Try());
            return new TryAsync<A>(() => result.Value);
        }

        [Pure]
        public static async Task<Result<T>> Try<T>(this TryAsync<T> self)
        {
            if (self == null) return None.Value;
            try
            {
                return await self();
            }
            catch (Exception e)
            {
                return e;
            }
        }

        [Pure]
        public static async Task<Result<B>> Try<A,B>(this TryAsync<A> self, Func<A,Task<B>> select)
        {
            if (self == null) return None.Value;
            try
            {
                var result = await self();
                if (result is Some<A> res)
                {
                    return await select(res);
                }
                return None.Value;
            }
            catch (Exception e)
            {
                return e;
            }
        }

        [Pure]
        public static async Task<Result<B>> Try<A, B>(this TryAsync<A> self, Func<A, B> select)
        {
            if (self == null) return None.Value;
            try
            {
                var result = await self();
                return result.Map(select);
            }
            catch (Exception e)
            {
                return e;
            }
        }

        [Pure]
        public static async Task<Result<T>> Try<T>(this TryAsync<T> self, Func<T, Task> onSuccess)
        {
            if (self == null) return None.Value;
            try
            {
                var result = await self();

                if (result is Some<T> res)
                {
                    await onSuccess(res);
                }

                return result;
            }
            catch (Exception e)
            {
                return e;
            }
        }

        [Pure]
        public static TryAsync<B> Map<A, B>(this TryAsync<A> self, Func<A, B> f) =>
           Memoize(async () => await self.Try(f));
    }
}

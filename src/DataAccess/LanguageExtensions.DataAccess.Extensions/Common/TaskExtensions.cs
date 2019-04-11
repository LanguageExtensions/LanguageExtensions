using System;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess
{
    internal static class TaskExtensions
    {
        public static async Task<TResult> Map<TIn, TResult>(this Task<TIn> task, Func<TIn, TResult> map)
            => map(await task);
    }
}

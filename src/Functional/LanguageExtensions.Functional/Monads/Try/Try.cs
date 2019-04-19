using System.Threading.Tasks;

namespace LanguageExtensions.Functional
{
    public delegate Result<T> Try<T>();
    public delegate Task<Result<A>> TryAsync<A>();
}

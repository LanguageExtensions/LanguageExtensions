using System.Linq;

namespace LanguageExtensions.DataAccess.Abstractions
{
    public interface IQueryOptions<TEntity>
    {
        IQueryable<TEntity> Apply(IQueryable<TEntity> query);
    }

    public static class QueryOptionsExtensions
    {
        public static IQueryable<TEntity> Apply<TEntity>(this IQueryable<TEntity> query, IQueryOptions<TEntity> queryOptions) => queryOptions.Apply(query);
    }
}

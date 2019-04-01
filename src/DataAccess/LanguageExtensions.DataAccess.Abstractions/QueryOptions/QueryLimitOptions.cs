using System.Linq;

namespace LanguageExtensions.DataAccess.Abstractions
{
    public class QueryLimitOptions<TEntity>: IQueryOptions<TEntity>
    {
        public QueryLimitOptions(int limit) => Limit = limit;

        public int Limit { get; }

        public IQueryable<TEntity> Apply(IQueryable<TEntity> query)
            => query.Take(Limit);
    }
}

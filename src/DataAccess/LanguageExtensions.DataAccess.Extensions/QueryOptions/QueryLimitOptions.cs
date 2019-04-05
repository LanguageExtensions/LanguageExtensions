using LanguageExtensions.DataAccess;
using LanguageExtensions.DataAccess.Specifications;
using LanguageExtensions.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess
{
    public class QueryLimitOptions<TEntity>: IQueryOptions<TEntity>
    {
        public QueryLimitOptions(int limit) => Limit = limit;

        public int Limit { get; }

        public IQueryable<TEntity> Apply(IQueryable<TEntity> query)
            => query.Take(Limit);
    }

    public static class QueryLimitOptionsExtensions
    {
        public static Task<IReadOnlyList<TEntity>> TakeAsync<TEntity>(
            this IFindRepository<TEntity> repository,
            Expression<Func<TEntity, bool>> predicate,
            int count)
                where TEntity : class
                    => repository.WhereAsync(predicate.ToSpecification(), new QueryLimitOptions<TEntity>(count));

        public static Task<IReadOnlyList<TEntity>> TakeAsync<TEntity>(
            this IFindRepository<TEntity> repository,
            Specification<TEntity> specification,
            int count)
                where TEntity : class
                    => repository.WhereAsync(specification, new QueryLimitOptions<TEntity>(count));

        public static Task<IReadOnlyList<TEntity>> TakeAsync<TEntity>(
            this IFindRepository<TEntity> repository,
            int count)
                where TEntity : class
                    => repository.GetAllAsync(new QueryLimitOptions<TEntity>(count));
    }
}

using LanguageExtensions.DataAccess.Specifications;
using LanguageExtensions.Specifications;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess
{
    public static class AggregateRepositoryExtensions_Count
    {
        public static async Task<long> CountAsync<TEntity>(this IQueryRepository<TEntity> repository)
            where TEntity : class
                => await repository.CountAsync(Specification<TEntity>.True);

        public static async Task<long> CountAsync<TEntity>(
            this IQueryRepository<TEntity> repository,
            Expression<Func<TEntity, bool>> predicate)
                where TEntity : class
                    => await repository.CountAsync(predicate.ToSpecification());
    }
}

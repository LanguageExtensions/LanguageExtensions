using LanguageExtensions.Specifications;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess
{
    public static class FindRepositoryExtensions_GetAll
    {
        public static Task<IReadOnlyList<TEntity>> GetAllAsync<TEntity>(
            this IFindRepository<TEntity> repository)
                where TEntity : class
                    => repository.WhereAsync(Specification<TEntity>.True);

        public static Task<IReadOnlyList<TResult>> GetAllAsync<TEntity, TResult>(
            this IFindRepository<TEntity> repository,
            Expression<Func<TEntity, TResult>> selector)
                where TEntity : class
                    => repository.WhereAsync(Specification<TEntity>.True, selector);

        public static Task<IReadOnlyList<TResult>> GetAllAsync<TEntity, TResult>(
            this IFindRepository<TEntity> repository,
            Expression<Func<TEntity, TResult>> selector,
            IQueryOptions<TEntity> queryOptions)
                where TEntity : class
                    => repository.WhereAsync(Specification<TEntity>.True, queryOptions, selector);

        public static Task<IReadOnlyList<TEntity>> GetAllAsync<TEntity>(
            this IFindRepository<TEntity> repository,
            IQueryOptions<TEntity> queryOptions)
                where TEntity : class
                    => repository.WhereAsync(Specification<TEntity>.True, queryOptions);
    }
}

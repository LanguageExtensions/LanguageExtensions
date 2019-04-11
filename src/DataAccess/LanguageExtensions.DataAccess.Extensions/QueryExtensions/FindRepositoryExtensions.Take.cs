using LanguageExtensions.DataAccess.Specifications;
using LanguageExtensions.Specifications;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess
{
    public static class FindRepositoryExtensions_Take
    {
        #region Expression

        public static Task<IReadOnlyList<TEntity>> TakeAsync<TEntity>(
            this IFindRepository<TEntity> repository,
            Expression<Func<TEntity, bool>> predicate,
            int count)
                where TEntity : class
                    => repository.WhereAsync(predicate.ToSpecification(), new QueryLimitOptions<TEntity>(count));

        public static Task<IReadOnlyList<TResult>> TakeAsync<TEntity, TResult>(
            this IFindRepository<TEntity> repository,
            Expression<Func<TEntity, bool>> predicate,
            Expression<Func<TEntity, TResult>> selector,
            int count)
                where TEntity : class
                    => repository.WhereAsync(predicate.ToSpecification(), selector, new QueryLimitOptions<TEntity>(count));

        #endregion

        #region Specification

        public static Task<IReadOnlyList<TEntity>> TakeAsync<TEntity>(
            this IFindRepository<TEntity> repository,
            Specification<TEntity> specification,
            int count)
                where TEntity : class
                    => repository.WhereAsync(specification, new QueryLimitOptions<TEntity>(count));

        public static Task<IReadOnlyList<TResult>> TakeAsync<TEntity, TResult>(
            this IFindRepository<TEntity> repository,
            Specification<TEntity> specification,
            Expression<Func<TEntity, TResult>> selector,
            int count)
                where TEntity : class
                    => repository.WhereAsync(specification, selector, new QueryLimitOptions<TEntity>(count));

        #endregion

        public static Task<IReadOnlyList<TEntity>> TakeAsync<TEntity>(
            this IFindRepository<TEntity> repository,
            int count)
                where TEntity : class
                    => repository.WhereAsync(Specification<TEntity>.True, new QueryLimitOptions<TEntity>(count));
    }
}

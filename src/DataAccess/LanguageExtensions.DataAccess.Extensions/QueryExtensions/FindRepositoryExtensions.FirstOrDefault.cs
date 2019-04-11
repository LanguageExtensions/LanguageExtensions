using LanguageExtensions.Specifications;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess
{
    public static class FindRepositoryExtensions_FirstOrDefault
    {
        public static async Task<TEntity> FirstOrDefaultAsync<TEntity>(
            this IFindRepository<TEntity> repository)
                where TEntity : class 
                    => await repository.TakeAsync(1).Map(r => r.FirstOrDefault());

        public static async Task<TEntity> FirstOrDefaultAsync<TEntity>(
            this IFindRepository<TEntity> repository,
            Specification<TEntity> specification)
                where TEntity : class
                    => await repository.TakeAsync(specification, 1).Map(r => r.FirstOrDefault());

        public static async Task<TEntity> FirstOrDefaultAsync<TEntity>(
            this IFindRepository<TEntity> repository,
            Expression<Func<TEntity, bool>> predicate)
                where TEntity : class
                    => await repository.TakeAsync(predicate, 1).Map(r => r.FirstOrDefault());

        public static async Task<TResult> FirstOrDefaultAsync<TEntity, TResult>(
            this IFindRepository<TEntity> repository,
            Specification<TEntity> specification,
            Expression<Func<TEntity, TResult>> selector)
                where TEntity : class
                    => await repository.TakeAsync(specification, selector, 1).Map(r => r.FirstOrDefault());

        public static async Task<TResult> FirstOrDefaultAsync<TEntity, TResult>(
            this IFindRepository<TEntity> repository,
            Expression<Func<TEntity, bool>> predicate,
            Expression<Func<TEntity, TResult>> selector)
                where TEntity : class
                    => await repository.TakeAsync(predicate, selector, 1).Map(r => r.FirstOrDefault());

    }
}

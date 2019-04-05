using LanguageExtensions.Specifications;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess.Abstractions
{
    public interface IFindRepository<TEntity> : IDisposable
        where TEntity : class
    {
        Task<bool> AnyAsync(Specification<TEntity> specification);
        Task<TEntity> FirstOrDefaultAsync(Specification<TEntity> specification);
        Task<IReadOnlyList<TEntity>> WhereAsync(Specification<TEntity> specification);
        Task<IReadOnlyList<TEntity>> WhereAsync(Specification<TEntity> specification, IQueryOptions<TEntity> queryOptions);
        Task<IReadOnlyList<TEntity>> GetAllAsync(IQueryOptions<TEntity> queryOptions);
    }

    public static class FindRepositoryExtensions
    {
        public static Task<bool> AnyAsync<TEntity>(this IFindRepository<TEntity> repository, Expression<Func<TEntity, bool>> predicate)
             where TEntity : class
                => repository.AnyAsync(predicate.ToSpecification());

        public static Task<TEntity> FirstOrDefaultAsync<TEntity>(this IFindRepository<TEntity> repository, Expression<Func<TEntity, bool>> predicate)
             where TEntity : class
                => repository.FirstOrDefaultAsync(predicate.ToSpecification());

        public static Task<IReadOnlyList<TEntity>> WhereAsync<TEntity>(this IFindRepository<TEntity> repository, Expression<Func<TEntity, bool>> predicate)
             where TEntity : class
                => repository.WhereAsync(predicate.ToSpecification());

        public static Task<IReadOnlyList<TEntity>> WhereAsync<TEntity>(
            this IFindRepository<TEntity> repository, 
            Expression<Func<TEntity, bool>> predicate, 
            IQueryOptions<TEntity> queryOptions)
                where TEntity : class
                    => repository.WhereAsync(predicate.ToSpecification(), queryOptions);
    }
}

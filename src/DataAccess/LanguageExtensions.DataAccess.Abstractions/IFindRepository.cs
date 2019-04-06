using LanguageExtensions.Specifications;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess
{
    public interface IFindRepository<TEntity> : IDisposable
        where TEntity : class
    {
        Task<bool> AnyAsync(Specification<TEntity> specification);
        Task<TEntity> FirstOrDefaultAsync(Specification<TEntity> specification);

        Task<IReadOnlyList<TResult>> WhereAsync<TResult>(Specification<TEntity> specification, IQueryOptions<TEntity> queryOptions, Expression<Func<TEntity, TResult>> selector);

        Task<IReadOnlyList<TEntity>> GetAllAsync(IQueryOptions<TEntity> queryOptions);
    }
}

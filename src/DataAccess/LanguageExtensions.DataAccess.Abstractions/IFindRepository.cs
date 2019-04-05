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
}

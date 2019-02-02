using LanguageExtensions.Specifications;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess.Abstractions
{
    public interface IFindRepository<TEntity> : IDisposable
        where TEntity : class
    {
        Task<TEntity> FindAsync(Specification<TEntity> specification);
    }

    public static class FindRepositoryExtensions
    {
        public static Task<TEntity> FindAsync<TEntity>(this IFindRepository<TEntity> repository, Expression<Func<TEntity, bool>> predicate)
             where TEntity : class
                => repository.FindAsync(predicate.ToSpecification());
    }
}

using LanguageExtensions.Specifications;
using System;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess
{
    public interface IAggregateRepository<TEntity> : IDisposable
        where TEntity : class
    {
        Task<long> CountAsync(Specification<TEntity> specification);
    }
}

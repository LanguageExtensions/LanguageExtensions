using LanguageExtensions.Specifications;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess
{
    public static class FindRepositoryExtensions_GetAll
    {
        public static Task<IReadOnlyList<TEntity>> GetAllAsync<TEntity>(
            this IFindRepository<TEntity> repository)
                where TEntity : class
                    => repository.WhereAsync(Specification<TEntity>.True);
    }
}

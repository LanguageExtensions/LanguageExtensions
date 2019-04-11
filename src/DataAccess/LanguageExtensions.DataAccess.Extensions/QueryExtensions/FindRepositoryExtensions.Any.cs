using LanguageExtensions.DataAccess.Specifications;
using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess
{
    public static class FindRepositoryExtensions_Any
    {
        #region Any

        public static Task<bool> AnyAsync<TEntity>(
            this IFindRepository<TEntity> repository,
            Expression<Func<TEntity, bool>> predicate)
                where TEntity : class
                    => repository.AnyAsync(predicate.ToSpecification());

        #endregion
    }
}

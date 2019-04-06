using System.Linq;

namespace LanguageExtensions.DataAccess
{
    public class NoneQueryOptions<TEntity> : IQueryOptions<TEntity>
    {
        public IQueryable<TEntity> Apply(IQueryable<TEntity> query) => query;
    }
}

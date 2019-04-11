using LanguageExtensions.DataAccess;
using LanguageExtensions.DataAccess.Specifications;
using LanguageExtensions.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess
{
    public class QueryLimitOptions<TEntity>: IQueryOptions<TEntity>
    {
        public QueryLimitOptions(int limit) => Limit = limit;

        public int Limit { get; }

        public IQueryable<TEntity> Apply(IQueryable<TEntity> query)
            => query.Take(Limit);
    }

}

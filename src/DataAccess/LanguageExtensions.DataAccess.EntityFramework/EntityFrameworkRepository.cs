using LanguageExtensions.Specifications;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess.EntityFramework
{
    public class EntityFrameworkRepository<TEntity, TKey> :
        EntityFrameworkRepository<TEntity>,
        ICommandRepository<TEntity, TKey>,
        IQueryRepository<TEntity, TKey>,
        IRepositoryWithKey<TEntity, TKey>
            where TEntity : class
    {
        #region Constructor

        public EntityFrameworkRepository(DbContext dbContext, Expression<Func<TEntity, TKey>> primaryKeySelector)
            : base(dbContext)
        {
            PrimaryKeySelector = primaryKeySelector;
        }

        #endregion

        #region IRepositoryWithKey Implementation

        public Expression<Func<TEntity, TKey>> PrimaryKeySelector { get; }

        #endregion

        #region IGetRepository Implementation

        public async Task<TEntity> GetAsync(TKey key)
        {
            var spec = this.GetPrimaryKeySpecification(key);
            return await _dbSet.FirstOrDefaultAsync(spec);
        }

        public async Task<IEnumerable<TEntity>> GetManyAsync(IEnumerable<TKey> keys)
        {
            var spec = this.GetPrimaryKeySpecification(keys);
            return await _dbSet.Where(spec).ToListAsync();
        }

        #endregion

        #region IInsertRepository

        public async Task<TKey> AddAsync(TEntity entity)
        {
            _dbSet.Add(entity);
            await _dbContext.SaveChangesAsync();
            return this.GetPrimaryKey(entity);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            entities.ToList().ForEach(entity => _dbSet.Add(entity));
            await _dbContext.SaveChangesAsync();
        }

        #endregion

        #region IUpdateRepository

        public async Task UpdateAsync(TEntity entity)
        {
            var entry = _dbContext.Entry(entity);

            if (entry.State == EntityState.Detached)
            {
                var key = this.GetPrimaryKey(entity);

                // check to see if this item is already attached
                //  if it is then we need to copy the values to the attached value instead of changing the State to modified since it will throw a duplicate key exception
                //  specifically: "An object with the same key already exists in the ObjectStateManager. The ObjectStateManager cannot track multiple objects with the same key."
                var attachedEntity = _dbContext.Set<TEntity>().Find(key);
                if (attachedEntity != null)
                {
                    _dbContext.Entry(attachedEntity).CurrentValues.SetValues(entity);
                }
            }
            else
            {
                // default
                entry.State = EntityState.Modified;
            }
            await _dbContext.SaveChangesAsync();
        }

        #endregion
    }

    public class EntityFrameworkRepository<TEntity> :
        IQueryRepository<TEntity>
            where TEntity : class
    {
        #region protected Fields

        protected readonly IDbSet<TEntity> _dbSet;
        protected DbContext _dbContext;

        #endregion

        #region Constructor

        public EntityFrameworkRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        #endregion

        #region IFindRepository Implementation

        public async Task<bool> AnyAsync(Specification<TEntity> specification)
        {
            if (specification.IsTrue()) return true;
            if (specification.IsFalse()) return false;

            return await _dbSet.AsNoTracking().AnyAsync(specification);
        }

        public async Task<IReadOnlyList<TResult>> WhereAsync<TResult>(
            Specification<TEntity> specification,
            IQueryOptions<TEntity> queryOptions,
            Expression<Func<TEntity, TResult>> selector)
        {
            if (specification.IsFalse()) return Enumerable.Empty<TResult>().ToList();

            IQueryable<TEntity> filteredResults = specification.IsTrue() ? _dbSet.AsNoTracking() : _dbSet.AsNoTracking().Where(specification);

            return await filteredResults
                .Apply(queryOptions)
                .Select(selector).ToListAsync();
        }

        #endregion

        #region IAggregateRepository Implementation

        public async Task<long> CountAsync(Specification<TEntity> specification)
        {
            if (specification.IsTrue()) return await _dbSet.LongCountAsync();
            if (specification.IsFalse()) return 0;

            return await _dbSet.CountAsync(specification);
        }

        #endregion

        #region IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing) return;
            if (_dbContext == null) return;

            _dbContext.Dispose();
            _dbContext = null;
        }

        #endregion
    }
}

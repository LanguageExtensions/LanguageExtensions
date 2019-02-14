using LanguageExtensions.DataAccess.Abstractions;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using LanguageExtensions.Specifications;
using System.Reflection;

namespace LanguageExtensions.DataAccess.InMemory
{
    public class InMemoryRepository<TEntity, TKey> :
        InMemoryRepository<TEntity>,
        IInsertRepository<TEntity, TKey>,
        IGetRepository<TEntity, TKey>,
        IRepositoryWithKey<TEntity, TKey>
            where TEntity : class
    {
        #region Constructor

        public InMemoryRepository(Expression<Func<TEntity, TKey>> primaryKeySelector, IEnumerable<TEntity> seedData) : base(seedData)
        {
            PrimaryKeySelector = primaryKeySelector;
        }

        #endregion

        #region IGetRepository Implementation

        public Task<TEntity> GetAsync(TKey key)
            => Task.FromResult(_data.FirstOrDefault(this.GetPrimaryKeySpecification(key).IsSatisfiedBy));

        public Task<IEnumerable<TEntity>> GetManyAsync(IEnumerable<TKey> keys)
            => Task.FromResult<IEnumerable<TEntity>>(_data.Where(this.GetPrimaryKeySpecification(keys).IsSatisfiedBy).ToList());

        #endregion

        #region IRepositoryWithKey Implementation

        public Expression<Func<TEntity, TKey>> PrimaryKeySelector { get; }

        #endregion

        #region IInsertRepositoryImplementation

        public Task<TKey> AddAsync(TEntity entity)
        {
            TKey primaryKey = this.GetPrimaryKey(entity);
            if (primaryKey.Equals(default(TKey))) this.SetPrimaryKey(entity, GenerateKey());
            else if (_data.Any(u => u.GetPropertyValue(PrimaryKeySelector).Equals(primaryKey))) this.SetPrimaryKey(entity, GenerateKey());
            _data.Add(entity);
            return Task.FromResult(this.GetPrimaryKey(entity));
        }

        public Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            _data.AddRange(entities);
            return Task.CompletedTask;
        }

        #endregion

        private TKey GenerateKey()
        {
            object returnVal;
            TKey currentMax = _data.Select(PrimaryKeySelector.Compile()).Max();
            switch (currentMax)
            {
                case int intValue: returnVal = intValue++; break;
                case long longValue: returnVal = longValue++; break;
                case decimal decimalValue: returnVal = decimalValue++; break;
                case Guid _:
                    returnVal = Guid.NewGuid();
                    break;
                default:
                    returnVal = default(TKey);
                    break;
            }
            return (TKey)returnVal;
        }
    }

    public class InMemoryRepository<TEntity> : IFindRepository<TEntity>
            where TEntity : class
    {
        #region protected fields

        protected List<TEntity> _data;

        #endregion

        #region Constructor

        public InMemoryRepository(IEnumerable<TEntity> seedData)
        {
            _data = seedData.ToList();
        }

        #endregion

        #region IFindRepository Implementation

        public Task<TEntity> FindAsync(Specification<TEntity> specification) => Task.FromResult(_data.FirstOrDefault(specification.IsSatisfiedBy));

        #endregion

        #region IDisposable

        public void Dispose() => _data = null;

        #endregion
    }

    public static class InMemoryExtensions
    {
        public static TEntity SetPrimaryKey<TEntity, TKey>(
            this IRepositoryWithKey<TEntity, TKey> repository,
            TEntity entity,
            TKey key)
                where TEntity : class
        {
            entity.SetPropertyValue(repository.PrimaryKeySelector, key);
            return entity;
        }

        public static T SetPropertyValue<T, TValue>(this T target, Expression<Func<T, TValue>> memberLamda, TValue value)
        {
            var memberSelectorExpression = memberLamda.Body as MemberExpression;
            var property = memberSelectorExpression?.Member as PropertyInfo;
            property?.SetValue(target, value, null);
            return target;
        }
    }
}

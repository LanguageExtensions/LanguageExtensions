﻿using LanguageExtensions.DataAccess;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using LanguageExtensions.Specifications;

namespace LanguageExtensions.DataAccess.InMemory
{
    public class InMemoryRepository<TEntity, TKey> :
        InMemoryRepository<TEntity>,
        ICommandRepository<TEntity, TKey>,
        IQueryRepository<TEntity, TKey>
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

        #region IUpdateRepository

        public Task UpdateAsync(TEntity entity)
        {
            TKey key = this.GetPrimaryKey(entity);
            var index = _data.FindIndex(this.GetPrimaryKeySpecification(key).IsSatisfiedBy);
            _data[index] = entity;
            return Task.CompletedTask;
        }

        #endregion

        #region Private helpers

        private TKey GenerateKey()
        { 
            object returnVal;
            TKey currentMax = _data.Select(PrimaryKeySelector.Compile()).Max();
            switch (currentMax)
            {
                case int intValue: returnVal = ++intValue; break;
                case long longValue: returnVal = ++longValue; break;
                case decimal decimalValue: returnVal = ++decimalValue; break;
                case Guid _:
                    returnVal = Guid.NewGuid();
                    break;
                default:
                    returnVal = default(TKey);
                    break;
            }
            return (TKey)returnVal;
        } 

        #endregion
    }

    public class InMemoryRepository<TEntity> :
        IQueryRepository<TEntity>
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

        public async Task<bool> AnyAsync(Specification<TEntity> specification)
        {
            if (specification.IsTrue()) return true;
            if (specification.IsFalse()) return false;

            return await Task.FromResult(_data.Any(specification.IsSatisfiedBy));
        }

        public async Task<IReadOnlyList<TResult>> WhereAsync<TResult>(
            Specification<TEntity> specification,
            IQueryOptions<TEntity> queryOptions,
            Expression<Func<TEntity, TResult>> selector)
        {
            if (specification.IsFalse()) return Enumerable.Empty<TResult>().ToList();

            IQueryable<TEntity> filteredResults = specification.IsTrue() ? _data.AsQueryable() : _data.AsQueryable().Where(specification);

            return filteredResults
                    .Apply(queryOptions)
                    .Select(selector)
                    .ToList();
        }

        #endregion

        #region IAggregateRepository Implementation

        public async Task<long> CountAsync(Specification<TEntity> specification)
        {
            if (specification.IsTrue()) return await Task.FromResult(_data.Count);
            if (specification.IsFalse()) return 0;

            return _data.Where(specification.IsSatisfiedBy).LongCount();
        }

        #endregion

        #region IDisposable

        public void Dispose() => _data = null;

        #endregion
    }
}

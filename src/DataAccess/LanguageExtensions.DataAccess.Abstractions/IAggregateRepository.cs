﻿using LanguageExtensions.Specifications;
using System;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess.Abstractions
{
    public interface IAggregateRepository<TEntity> : IDisposable
        where TEntity : class
    {
        Task<long> Count();
        Task<long> Count(Specification<TEntity> specification);
    }
}
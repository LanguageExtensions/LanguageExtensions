using LanguageExtensions.DataAccess;
using LanguageExtensions.DataAccess.Specifications;
using LanguageExtensions.Specifications;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess
{
    public static class FindRepositoryExtensions_Where
    {
        #region Specification

        /// <summary>
        /// Expression based where execution
        /// </summary>
        /// <example>
        /// <code>
        /// var users = await repository(user => user.Age > 15);
        /// </code>
        /// </example>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="repository"></param>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public static Task<IReadOnlyList<TEntity>> WhereAsync<TEntity>(
            this IFindRepository<TEntity> repository,
            Expression<Func<TEntity, bool>> predicate)
                where TEntity : class
                    => repository.WhereAsync(predicate.ToSpecification());

        /// <summary>
        /// 
        /// </summary>
        /// <example>
        /// <code>
        /// var userNames = await repository(
        ///         user => user.Age > 15,
        ///         user => user.UserName
        ///     );
        /// </code>
        /// </example>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="repository"></param>
        /// <param name="predicate"></param>
        /// <param name="selector"></param>
        /// <returns></returns>
        public static Task<IReadOnlyList<TResult>> WhereAsync<TEntity, TResult>(
            this IFindRepository<TEntity> repository,
            Expression<Func<TEntity, bool>> predicate,
            Expression<Func<TEntity, TResult>> selector)
                where TEntity : class
                    => repository.WhereAsync(predicate.ToSpecification(), selector);

        /// <summary>
        /// 
        /// </summary>
        /// <example>
        /// <code>
        /// var userNames = await repository(
        ///         user => user.Age > 15,
        ///         user => user.UserName,
        ///         new LimitQueryOptions(50)
        ///     );
        /// </code>
        /// </example>
        /// <typeparam name="TEntity"></typeparam>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="repository"></param>
        /// <param name="predicate"></param>
        /// <param name="selector"></param>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public static Task<IReadOnlyList<TResult>> WhereAsync<TEntity, TResult>(
            this IFindRepository<TEntity> repository,
            Expression<Func<TEntity, bool>> predicate,
            Expression<Func<TEntity, TResult>> selector,
            IQueryOptions<TEntity> queryOptions)
                where TEntity : class
                    => repository.WhereAsync(predicate.ToSpecification(), queryOptions, selector);

        /// <summary>
        /// 
        /// </summary>
        /// <example>
        /// <code>
        /// var users = await repository(
        ///         user => user.Age > 15,
        ///         new LimitQueryOptions(50)
        ///     );
        /// </code>
        /// </example>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="repository"></param>
        /// <param name="predicate"></param>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public static Task<IReadOnlyList<TEntity>> WhereAsync<TEntity>(
            this IFindRepository<TEntity> repository,
            Expression<Func<TEntity, bool>> predicate,
            IQueryOptions<TEntity> queryOptions)
                where TEntity : class
                    => repository.WhereAsync(predicate.ToSpecification(), queryOptions);

        #endregion

        #region Expression

        public static Task<IReadOnlyList<TEntity>> WhereAsync<TEntity>(
            this IFindRepository<TEntity> repository,
            Specification<TEntity> specification)
                where TEntity : class
                    => repository.WhereAsync(specification, new NoneQueryOptions<TEntity>(), e => e);

        public static Task<IReadOnlyList<TResult>> WhereAsync<TEntity, TResult>(
            this IFindRepository<TEntity> repository,
            Specification<TEntity> specification,
            Expression<Func<TEntity, TResult>> selector)
                where TEntity : class
                    => repository.WhereAsync(specification, new NoneQueryOptions<TEntity>(), selector);

        public static Task<IReadOnlyList<TEntity>> WhereAsync<TEntity>(
            this IFindRepository<TEntity> repository,
            Specification<TEntity> specification,
            IQueryOptions<TEntity> queryOptions)
                where TEntity : class
                    => repository.WhereAsync(specification, queryOptions, e => e);

        #endregion
    }
}

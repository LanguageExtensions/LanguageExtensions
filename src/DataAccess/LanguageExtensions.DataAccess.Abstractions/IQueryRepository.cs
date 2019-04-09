namespace LanguageExtensions.DataAccess
{
    public interface IQueryRepository<TEntity> : 
        IFindRepository<TEntity>,
        IAggregateRepository<TEntity>
            where TEntity : class
    {
    }

    public interface IQueryRepository<TEntity, TKey> : 
        IQueryRepository<TEntity>,
        IGetRepository<TEntity, TKey>
            where TEntity : class
    {
    }
}

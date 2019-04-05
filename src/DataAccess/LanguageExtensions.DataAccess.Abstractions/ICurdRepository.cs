namespace LanguageExtensions.DataAccess
{
    public interface ICurdRepository<TEntity, TKey>: 
        IFindRepository<TEntity>, 
        IGetRepository<TEntity, TKey>,
        IInsertRepository<TEntity, TKey>,
        IUpdateRepository<TEntity, TKey>
            where TEntity : class
    {
    }
}

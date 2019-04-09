namespace LanguageExtensions.DataAccess
{
    public interface ICommandRepository<TEntity, TKey>: 
        IInsertRepository<TEntity, TKey>,
        IUpdateRepository<TEntity, TKey>
            where TEntity : class
    {
    }
}

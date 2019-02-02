namespace LanguageExtensions.DataAccess.Abstractions
{
    public interface ICurdRepository<TEntity, TKey>: 
        IFindRepository<TEntity>, 
        IGetRepository<TEntity, TKey> where TEntity : class
    {
    }
}

namespace LanguageExtensions.DataAccess.Abstractions
{
    public interface ICurdRepository<T, TKey>: IInsertRepository<T, TKey>, IGetRepository<T, TKey>
    {
    }
}

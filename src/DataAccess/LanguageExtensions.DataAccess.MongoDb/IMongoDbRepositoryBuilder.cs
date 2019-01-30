using Microsoft.Extensions.DependencyInjection;

namespace LanguageExtensions.DataAccess.MongoDb
{
    public interface IMongoDbRepositoryBuilder
    {
        IServiceCollection Services { get; }
        IMongoDbRepositoryBuilder ConfigureRepository<T, TKey>();
    }

    internal class MongoDbRepositoryBuilder : IMongoDbRepositoryBuilder
    {
        public MongoDbRepositoryBuilder(IServiceCollection services)
        {
            Services = services;
        }
        public IServiceCollection Services { get; }

        public IMongoDbRepositoryBuilder ConfigureRepository<T, TKey>() => throw new System.NotImplementedException();
    }
}

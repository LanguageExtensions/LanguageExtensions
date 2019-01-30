using Microsoft.Extensions.DependencyInjection;
using MongoDB.Driver;

namespace LanguageExtensions.DataAccess.MongoDb
{
    public static class MongoDbRepositoryExtensions
    {
        public static IMongoDbRepositoryBuilder ConfigureMongoRepository(
            this IServiceCollection services, 
            string mongoDbConnection)
        {
            services.AddSingleton(service => CreateMongoDbClient(mongoDbConnection));

            return new MongoDbRepositoryBuilder(services);
        }

        private static IMongoClient CreateMongoDbClient(string mongoDbConnection)
        {
            return new MongoClient(mongoDbConnection);
        }
    }



    public class MongoDbConfiguration
    {
        public MongoDbConfiguration(string connectionString)
        {
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; set; }
    }
}

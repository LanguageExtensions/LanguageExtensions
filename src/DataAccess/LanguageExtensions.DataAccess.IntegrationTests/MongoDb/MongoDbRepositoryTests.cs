using LanguageExtensions.DataAccess.Abstractions;
using LanguageExtensions.DataAccess.MongoDb;
using MongoDB.Driver;
using NUnit.Framework;

namespace LanguageExtensions.DataAccess.IntegrationTests.MongoDb
{
    public class MongoDbRepositoryTests : GetRepositoryTestBase
    {
        
        protected override IGetRepository<UserDto, long> GetRepository()
        {
            var mongoClient = new MongoClient();
            return new MongoDbRepository<UserDto, long>(mongoClient, "test_user_db", u => u.Id);
        }

        [SetUp]
        public void Setup()
        {
            MongoClient mongoClient = new MongoClient();
            mongoClient.DropDatabase("test_user_db");
            mongoClient.GetDatabase("test_user_db").GetCollection<UserDto>("UserDto").InsertMany(GetSeedData());
        }
    }
}

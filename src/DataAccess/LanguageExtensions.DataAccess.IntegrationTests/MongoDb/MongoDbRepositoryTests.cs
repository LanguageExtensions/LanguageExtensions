using LanguageExtensions.DataAccess.Abstractions;
using LanguageExtensions.DataAccess.MongoDb;
using MongoDB.Driver;
using NUnit.Framework;

namespace LanguageExtensions.DataAccess.IntegrationTests.MongoDb
{
    public class MongoDbRepositoryTests : GetRepositoryTestBase
    {
        private MongoClient _mongoClient;

        protected override IGetRepository<UserDto, long> GetPrimaryKeyRepository()
        {
            return new MongoDbRepository<UserDto, long>(_mongoClient, "test_user_db", u => u.Id);
        }

        [SetUp]
        public void Setup()
        {
            _mongoClient = new MongoClient();
            _mongoClient.DropDatabase("test_user_db");
            _mongoClient.GetDatabase("test_user_db").GetCollection<UserDto>("UserDto").InsertMany(GetSeedData());
        }

        protected override IFindRepository<UserDto> GetFindRepository() 
            => new MongoDbRepository<UserDto>(_mongoClient, "test_user_db");
    }
}

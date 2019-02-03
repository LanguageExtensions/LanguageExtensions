using LanguageExtensions.DataAccess.Abstractions;
using LanguageExtensions.DataAccess.IntegrationTests.Models;
using LanguageExtensions.DataAccess.MongoDb;
using MongoDB.Driver;
using NUnit.Framework;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess.IntegrationTests.MongoDb
{
    public class MongoDb_GetRepository_Tests : GetRepositoryTestBase
    {
        private static readonly string _dbName = "get_user_db";
        private MongoClient _mongoClient;
        private MongoDbRepository<UserDto, long> _repository;

        protected override IGetRepository<UserDto, long> GetPrimaryKeyRepository() 
            => _repository;

        [SetUp]
        public async Task Setup()
        {
            _mongoClient = new MongoClient();
            var db = _mongoClient.GetDatabase(_dbName);
            await db.DropCollectionAsync("UserDto");
            await db.GetCollection<UserDto>("UserDto").InsertManyAsync(GetSeedUserData());
            _repository = new MongoDbRepository<UserDto, long>(_mongoClient, _dbName, u => u.Id);
        }

        [TearDown]
        public void TearDown()
        {
            _repository.Dispose();
            _repository = null;
            _mongoClient = null;
        }
    }

    public class MongoDb_FindRepository_Tests : FindRepositoryTestBase
    {
        private static readonly string _dbName = "find_user_db";
        private MongoClient _mongoClient;
        private MongoDbRepository<UserDto> _repository;

        [SetUp]
        public async Task Setup()
        {
            _mongoClient = new MongoClient();
            var db = _mongoClient.GetDatabase(_dbName);
            await db.DropCollectionAsync("UserDto");
            await db.GetCollection<UserDto>("UserDto").InsertManyAsync(GetSeedUserData());
            _repository = new MongoDbRepository<UserDto>(_mongoClient, _dbName);
        }

        [TearDown]
        public void TearDown()
        {
            _repository.Dispose();
            _repository = null;
            _mongoClient = null;
        }

        protected override IFindRepository<UserDto> GetFindRepository()
            => _repository;
    }

    public class MongoDb_InsertRepository_Tests : InsertRepositoryTestBase
    {
        private static readonly string _dbName = "insert_user_db";
        private MongoClient _mongoClient;
        private IMongoCollection<UserDto> _collection;
        private MongoDbRepository<UserDto, long> _repository;

        [SetUp]
        public async Task Setup()
        {
            _mongoClient = new MongoClient();
            var db = _mongoClient.GetDatabase(_dbName);
            await db.DropCollectionAsync("UserDto");
            _collection = db.GetCollection<UserDto>("UserDto");
            await _collection.InsertManyAsync(GetSeedUserData());


            _repository = new MongoDbRepository<UserDto, long>(_mongoClient, _dbName, u => u.Id);
        }
        [TearDown]
        public void TearDown()
        {
            _repository.Dispose();
            _repository = null;
            _mongoClient = null;
            _collection = null;
        }

        protected override IInsertRepository<UserDto, long> GetInsertKeyRepository()
            => _repository;

        protected override Task<UserDto> GetUserByIdAsync(long userId)
            => _collection.Find(u => u.Id == userId).FirstOrDefaultAsync();
    }
}

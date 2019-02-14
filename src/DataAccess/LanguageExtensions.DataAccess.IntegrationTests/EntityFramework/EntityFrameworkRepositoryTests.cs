using LanguageExtensions.DataAccess.Abstractions;
using LanguageExtensions.DataAccess.EntityFramework;
using LanguageExtensions.DataAccess.IntegrationTests.EntityFramework.DataContext;
using LanguageExtensions.DataAccess.IntegrationTests.Models;
using NUnit.Framework;
using System;
using System.Data.Entity;
using System.IO;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess.IntegrationTests.EntityFramework
{
    public class EntityFramework_GetRepository_Tests : GetRepositoryTestBase
    {
        private IGetRepository<UserDto, long> _repository;

        [SetUp]
        public async Task Setup()
        {
            var dbPath = GetDataFilePath();
            var dbContext = new UserDbContext("Data Source=" + dbPath);

            dbContext.Users.AddRange(GetSeedUserData());
            await dbContext.SaveChangesAsync();

            _repository = new EntityFrameworkRepository<UserDto, long>(dbContext, u => u.Id);
        }

        [TearDown]
        public void TearDown()
        {
            _repository.Dispose();
            _repository = null;
        }

        protected override IGetRepository<UserDto, long> GetPrimaryKeyRepository() => _repository;

        private static int _num = 1;
        public static string GetDataFilePath()
        {
            string dataDirectoryPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "LanguageExtensions.Tests.Integration",
                "Data",
                "Ef");

            if (!Directory.Exists(dataDirectoryPath))
                Directory.CreateDirectory(dataDirectoryPath);

            string dataFilePath = Path.Combine(dataDirectoryPath, $"GetEntitiesDb{_num}.sdf");
            _num++;

            if (File.Exists(dataFilePath))
                File.Delete(dataFilePath);

            return dataFilePath;
        }
    }

    public class EntityFramework_FindRepository_Tests : FindRepositoryTestBase
    {
        private IFindRepository<UserDto> _repository;

        [SetUp]
        public async Task Setup()
        {
            var dbPath = GetDataFilePath();
            var dbContext = new UserDbContext("Data Source=" + dbPath);

            dbContext.Users.AddRange(GetSeedUserData());
            await dbContext.SaveChangesAsync();

            _repository = new EntityFrameworkRepository<UserDto>(dbContext);
        }

        [TearDown]
        public void TearDown()
        {
            _repository.Dispose();
            _repository = null;
        }

        protected override IFindRepository<UserDto> GetFindRepository() => _repository;

        private static int _num = 1;
        public static string GetDataFilePath()
        {
            string dataDirectoryPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "LanguageExtensions.Tests.Integration",
                "Data",
                "Ef");

            if (!Directory.Exists(dataDirectoryPath))
                Directory.CreateDirectory(dataDirectoryPath);

            string dataFilePath = Path.Combine(dataDirectoryPath, $"FindEntitiesDb{_num}.sdf");
            _num++;

            if (File.Exists(dataFilePath))
                File.Delete(dataFilePath);

            return dataFilePath;
        }
    }

    public class EntityFramework_InsertRepository_Tests : InsertRepositoryTestBase
    {
        private EntityFrameworkRepository<UserDto, long> _repository;

        [SetUp]
        public async Task Setup()
        {
            var dbPath = GetDataFilePath();
            var dbContext = new UserDbContext("Data Source=" + dbPath);

            dbContext.Users.AddRange(GetSeedUserData());
            await dbContext.SaveChangesAsync();

            _repository = new EntityFrameworkRepository<UserDto, long>(dbContext, u => u.Id);
        }

        [TearDown]
        public void TearDown()
        {
            _repository.Dispose();
            _repository = null;
        }

        protected override IInsertRepository<UserDto, long> GetInsertKeyRepository() 
            => _repository;

        protected override async Task<UserDto> GetUserByIdAsync(long userId)
            => await _repository.GetAsync(userId);

        private static int _num = 1;
        public static string GetDataFilePath()
        {
            string dataDirectoryPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "LanguageExtensions.Tests.Integration",
                "Data",
                "Ef");

            if (!Directory.Exists(dataDirectoryPath))
                Directory.CreateDirectory(dataDirectoryPath);

            string dataFilePath = Path.Combine(dataDirectoryPath, $"InsertEntitiesDb{_num}.sdf");
            _num++;

            if (File.Exists(dataFilePath))
                File.Delete(dataFilePath);

            return dataFilePath;
        }
    }
}

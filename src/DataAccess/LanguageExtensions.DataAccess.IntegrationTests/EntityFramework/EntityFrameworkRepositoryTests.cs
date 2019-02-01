using LanguageExtensions.DataAccess.Abstractions;
using LanguageExtensions.DataAccess.EntityFramework;
using LanguageExtensions.DataAccess.IntegrationTests.EntityFramework.DataContext;
using NUnit.Framework;
using System;
using System.Data.Entity;
using System.IO;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess.IntegrationTests.EntityFramework
{
    public class EntityFrameworkRepositoryTests : GetRepositoryTestBase
    {
        private UserDbContext _dbContext;

        [SetUp]
        public async Task Setup()
        {
            var dbPath = GetDataFilePath();
            _dbContext = new UserDbContext("Data Source=" + dbPath);

            _dbContext.Users.AddRange(GetSeedData());
            await _dbContext.SaveChangesAsync();

            var users = await _dbContext.Users.ToListAsync();
        }

        protected override IFindRepository<UserDto> GetFindRepository() 
            => new EntityFrameworkRepository<UserDto>(_dbContext);

        protected override IGetRepository<UserDto, long> GetPrimaryKeyRepository() 
            => new EntityFrameworkRepository<UserDto, long>(_dbContext, u => u.Id);

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

            string dataFilePath = Path.Combine(dataDirectoryPath, $"TestEntitiesDb{_num}.sdf");
            _num++;

            if (File.Exists(dataFilePath))
                File.Delete(dataFilePath);

            return dataFilePath;
        }
    }
}

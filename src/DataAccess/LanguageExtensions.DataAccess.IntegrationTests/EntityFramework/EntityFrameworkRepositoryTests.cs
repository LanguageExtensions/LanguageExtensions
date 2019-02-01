using LanguageExtensions.DataAccess.Abstractions;
using LanguageExtensions.DataAccess.EntityFramework;
using NUnit.Framework;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess.IntegrationTests.EntityFramework
{
    public class EntityFrameworkRepositoryTests : GetRepositoryTestBase
    {
        private UserDataContext _dbContext;

        [SetUp]
        public async Task Setup()
        {
            var dbPath = EfDataDirectoryFactory.Build();
            _dbContext = new UserDataContext("Data Source=" + dbPath);

            _dbContext.Users.AddRange(GetSeedData());
            await _dbContext.SaveChangesAsync();

            var users = await _dbContext.Users.ToListAsync();
        }

        protected override IGetRepository<UserDto, long> GetRepository() => new EntityFrameworkRepository<UserDto, long>(_dbContext, u => u.Id);
    }

    [DbConfigurationType(typeof(TestConfiguration))]
    public class UserDataContext : DbContext
    {
        public UserDataContext(string connectionString) : base(connectionString)
        {
        }
        public DbSet<UserDto> Users { get; set; }
    }

    public class EfDataDirectoryFactory
    {
        private static int _num = 1;

        public static string Build()
        {
            var dataDirectory = GetDataDirectory();
            var efDataDirectoryPath = Path.Combine(dataDirectory, @"Ef");

            if (!Directory.Exists(efDataDirectoryPath))
            {
                Directory.CreateDirectory(efDataDirectoryPath);
            }

            var file = String.Format("{0}\\TestEntitiesDb{1}.sdf", efDataDirectoryPath, _num);
            _num++; // since it goes through and calls this for each test before running them, we need a different database for each test or else the auto increment goes to 2 on the second test with an add and it fails
                    // surprisingly the timing isn;'t too bad for this, the first test takes about 7 secs for EF to model the DB and create it, then each other test is super quick in creating the DB file

            if (File.Exists(file))
            {
                File.Delete(file);
            }

            return file;
        }

        public static string GetDataDirectory() => @"C:\Users\piyush_rathi\source\repos\SqlServerSeTestBed\SqlServerSeTestBed\Data";
    }

    public class TestConfiguration : DbConfiguration
    {
        public TestConfiguration()
        {
            SetDefaultConnectionFactory(new SqlCeConnectionFactory("System.Data.SqlServerCe.4.0"));
        }
    }
}

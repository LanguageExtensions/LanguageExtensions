using LanguageExtensions.DataAccess.IntegrationTests.Models;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace LanguageExtensions.DataAccess.IntegrationTests.EntityFramework.DataContext
{

    [DbConfigurationType(typeof(TestConfiguration))]
    public class UserDbContext : DbContext
    {
        public UserDbContext(string connectionString) : base(connectionString)
        {
        }
        public DbSet<UserDto> Users { get; set; }
    }

    public class TestConfiguration : DbConfiguration
    {
        public TestConfiguration()
        {
            SetDefaultConnectionFactory(new SqlCeConnectionFactory("System.Data.SqlServerCe.4.0"));
        }
    }
}

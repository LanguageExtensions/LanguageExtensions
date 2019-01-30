using LanguageExtensions.DataAccess.Abstractions;
using LanguageExtensions.DataAccess.EntityFramework;

namespace LanguageExtensions.DataAccess.IntegrationTests.EntityFramework
{
    public class EntityFrameworkRepositoryTests : GetRepositoryTestBase
    {
        protected override IGetRepository<UserDto, long> GetRepository() => new EntityFrameworkRepository<UserDto, long>(null, u => u.Id);
    }

    //public class UserDtoContext : DbContext
    //{
    //    public UserDtoContext()
    //    { }

    //    public BloggingContext(DbContextOptions<BloggingContext> options)
    //        : base(options)
    //    { }
    //}
    }

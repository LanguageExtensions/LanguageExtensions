using LanguageExtensions.DataAccess.Abstractions;
using LanguageExtensions.DataAccess.InMemory;

namespace LanguageExtensions.DataAccess.IntegrationTests.InMemory
{
    public class InMemoryRepositoryTests : GetRepositoryTestBase
    {
        protected override IGetRepository<UserDto, long> GetRepository() => new InMemoryRepository<UserDto, long>(u => u.Id, GetSeedData());
    }
}

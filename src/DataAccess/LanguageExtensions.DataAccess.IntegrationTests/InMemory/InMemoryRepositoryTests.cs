using LanguageExtensions.DataAccess.Abstractions;
using LanguageExtensions.DataAccess.InMemory;

namespace LanguageExtensions.DataAccess.IntegrationTests.InMemory
{
    public class InMemoryRepositoryTests : GetRepositoryTestBase
    {
        protected override IFindRepository<UserDto> GetFindRepository() 
            => new InMemoryRepository<UserDto>(GetSeedData());

        protected override IGetRepository<UserDto, long> GetPrimaryKeyRepository() 
            => new InMemoryRepository<UserDto, long>(u => u.Id, GetSeedData());
    }
}

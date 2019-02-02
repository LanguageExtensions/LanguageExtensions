using LanguageExtensions.DataAccess.Abstractions;
using LanguageExtensions.DataAccess.InMemory;

namespace LanguageExtensions.DataAccess.IntegrationTests.InMemory
{
    public class InMemory_GetRepository_Tests : GetRepositoryTestBase
    {
        protected override IGetRepository<UserDto, long> GetPrimaryKeyRepository()
            => new InMemoryRepository<UserDto, long>(u => u.Id, GetSeedData());
    }
    public class InMemory_FindRepository_Tests : FindRepositoryTestBase
    {
        protected override IFindRepository<UserDto> GetFindRepository()
            => new InMemoryRepository<UserDto>(GetSeedData());
    }
}

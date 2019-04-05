using System;
using System.Threading.Tasks;
using LanguageExtensions.DataAccess;
using LanguageExtensions.DataAccess.InMemory;
using LanguageExtensions.DataAccess.IntegrationTests.Models;
using NUnit.Framework;

namespace LanguageExtensions.DataAccess.IntegrationTests.InMemory
{
    public class InMemory_GetRepository_Tests : GetRepositoryTestBase
    {
        protected override IGetRepository<UserDto, long> GetPrimaryKeyRepository()
            => new InMemoryRepository<UserDto, long>(u => u.Id, GetSeedUserData());
    }
    public class InMemory_FindRepository_Tests : FindRepositoryTestBase
    {
        protected override IFindRepository<UserDto> GetFindRepository()
            => new InMemoryRepository<UserDto>(GetSeedUserData());
    }

    public class InMemory_InsertRepository_Test : InsertRepositoryTestBase
    {
        private InMemoryRepository<UserDto, long> _repository;

        [SetUp]
        public void Setup() 
            => _repository = new InMemoryRepository<UserDto, long>(u => u.Id, GetSeedUserData());

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
    }
}

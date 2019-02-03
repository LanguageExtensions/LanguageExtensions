using FluentAssertions;
using LanguageExtensions.DataAccess.Abstractions;
using LanguageExtensions.DataAccess.IntegrationTests.Models;
using NUnit.Framework;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess.IntegrationTests
{
    public abstract class InsertRepositoryTestBase : RepositoryTestBase
    {
        protected abstract IInsertRepository<UserDto, long> GetInsertKeyRepository();

        protected abstract Task<UserDto> GetUserByIdAsync(long userId);

        [TestCaseSource(nameof(InsertTestCaseData))]
        public async Task Should_be_able_to_add_single_item_with_valid_ID(UserDto newUser)
        {
            // Arrange
            var repository = GetInsertKeyRepository();
            // Act
            long userId = await repository.AddAsync(newUser);

            // Assert
            var userFromRepo = await GetUserByIdAsync(userId);
            userFromRepo.Should().Be(newUser);
        }

        public static IEnumerable InsertTestCaseData
        {
            get
            {
                foreach (var userData in GetSeedUserData_ForInsert().Select(user => new TestCaseData(user)))
                    yield return userData;
            }
        }
    }
}

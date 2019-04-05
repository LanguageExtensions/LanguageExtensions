using FluentAssertions;
using LanguageExtensions.DataAccess;
using LanguageExtensions.DataAccess.IntegrationTests.Models;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess.IntegrationTests
{
    public abstract class GetRepositoryTestBase: RepositoryTestBase
    {
        protected abstract IGetRepository<UserDto, long> GetPrimaryKeyRepository();

        [TestCase(6, "Danielle.Morissette49")]
        [TestCase(4, "Amy.Willms56")]
        public async Task Should_be_able_to_get_user_by_Id(long id, string expectedUserName)
        {
            var repository = GetPrimaryKeyRepository();
            var user = await repository.GetAsync(id).ConfigureAwait(false);
            user.UserName.Should().Be(expectedUserName);
        }

        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(100)]
        public async Task Should_return_null_when_user_with_Id_does_not_exist(long userId)
        {
            var repository = GetPrimaryKeyRepository();
            var user = await repository.GetAsync(userId).ConfigureAwait(false);
            user.Should().BeNull();
        }

        [TestCaseSource("GetMultipleUser_TestData")]
        public async Task Should_ge_able_to_get_multiple_users(long[] ids, int expectedResultsCount, string[] expectedUserNames)
        {
            var repository = GetPrimaryKeyRepository();
            var users = await repository.GetManyAsync(ids).ConfigureAwait(false);

            users.Should()
                .HaveCount(expectedResultsCount);
            users.Select(u => u.UserName).Should()
                .BeEquivalentTo(expectedUserNames);
        }

        #region Test Data

        public static IEnumerable<TestCaseData> GetMultipleUser_TestData
        {
            get
            {
                yield return new TestCaseData(new long[] { 6, 4 }, 2, new string[] { "Danielle.Morissette49", "Amy.Willms56" });
                yield return new TestCaseData(new long[] { 6, 4, 501 }, 2, new string[] { "Danielle.Morissette49", "Amy.Willms56" });
                yield return new TestCaseData(new long[] { 505 }, 0, new string[] { });
            }
        }

        #endregion
    }
}

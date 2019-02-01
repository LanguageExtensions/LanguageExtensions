using FluentAssertions;
using LanguageExtensions.DataAccess.Abstractions;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess.IntegrationTests
{
    public abstract class GetRepositoryTestBase
    {
        protected abstract IGetRepository<UserDto, long> GetRepository();

        protected IEnumerable<UserDto> GetSeedData()
        {
            using (StreamReader r = new StreamReader(TestContext.CurrentContext.TestDirectory + @"\Data\UserData.json"))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<List<UserDto>>(json);
            }
        }

        [TestCase(6, "Danielle.Morissette49")]
        [TestCase(4, "Amy.Willms56")]
        public async Task Should_be_able_to_get_user_by_Id(long id, string expectedUserName)
        {
            var repository = GetRepository();
            var user = await repository.GetAsync(id).ConfigureAwait(false);
            user.UserName.Should().Be(expectedUserName);
        }

        [Test]
        public async Task Should_return_null_when_user_with_Id_does_not_exist()
        {
            var repository = GetRepository();
            var user = await repository.GetAsync(15).ConfigureAwait(false);
            user.Should().BeNull();
        }

        [TestCaseSource("GetMultipleUser_TestData")]
        public async Task Should_ge_able_to_get_multiple_users(long[] ids, int expectedResultsCount, string[] expectedUserNames)
        {
            var repository = GetRepository();
            var users = await repository.GetManyAsync(ids).ConfigureAwait(false);

            users.Should()
                .HaveCount(expectedResultsCount);
            users.Select(u => u.UserName).Should()
                .BeEquivalentTo(expectedUserNames);
        }

        public static IEnumerable<TestCaseData> GetMultipleUser_TestData
        {
            get
            {
                yield return new TestCaseData(new long[] { 6, 4 }, 2, new string[] { "Danielle.Morissette49", "Amy.Willms56" });
                yield return new TestCaseData(new long[] { 6, 4, 12 }, 2, new string[] { "Danielle.Morissette49", "Amy.Willms56" });
                yield return new TestCaseData(new long[] { 12 }, 0, new string[] {});
            }
        }
    }


    public class UserDto
    {
        [Key]
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Contact { get; set; }

        public override string ToString() => $"{Id} : {UserName}";
    }
}

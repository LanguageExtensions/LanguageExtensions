using FluentAssertions;
using LanguageExtensions.DataAccess.Abstractions;
using LanguageExtensions.Specifications;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace LanguageExtensions.DataAccess.IntegrationTests
{
    public abstract class GetRepositoryTestBase: RepositoryTestBase
    {
        #region IGetRepository

        protected abstract IGetRepository<UserDto, long> GetPrimaryKeyRepository();

        [TestCase(6, "Danielle.Morissette49")]
        [TestCase(4, "Amy.Willms56")]
        public async Task Should_be_able_to_get_user_by_Id(long id, string expectedUserName)
        {
            var repository = GetPrimaryKeyRepository();
            var user = await repository.GetAsync(id).ConfigureAwait(false);
            user.UserName.Should().Be(expectedUserName);
        }

        [Test]
        public async Task Should_return_null_when_user_with_Id_does_not_exist()
        {
            var repository = GetPrimaryKeyRepository();
            var user = await repository.GetAsync(15).ConfigureAwait(false);
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

        #endregion

        public static IEnumerable<TestCaseData> GetMultipleUser_TestData
        {
            get
            {
                yield return new TestCaseData(new long[] { 6, 4 }, 2, new string[] { "Danielle.Morissette49", "Amy.Willms56" });
                yield return new TestCaseData(new long[] { 6, 4, 12 }, 2, new string[] { "Danielle.Morissette49", "Amy.Willms56" });
                yield return new TestCaseData(new long[] { 12 }, 0, new string[] { });
            }
        }
    }

    public abstract class FindRepositoryTestBase: RepositoryTestBase
    {
        protected abstract IFindRepository<UserDto> GetFindRepository();

        [TestCaseSource(nameof(Should_be_able_to_find_using_expression_data))]
        public async Task Should_be_able_to_find_using_expression(FindUserTestCaseData testCaseData)
        {
            var repository = GetFindRepository();
            var resultFromExpression = await repository.FindAsync(testCaseData.Predicate).ConfigureAwait(false);
            var resultFromSpecification = await repository.FindAsync(testCaseData.Predicate.ToSpecification()).ConfigureAwait(false);

            testCaseData.Expectation.ToSpecification()
                .IsSatisfiedBy(resultFromExpression)
                .Should().BeTrue();
            testCaseData.Expectation.ToSpecification()
                .IsSatisfiedBy(resultFromSpecification)
                .Should().BeTrue();
        }

        public static IEnumerable Should_be_able_to_find_using_expression_data
        {
            get
            {
                yield return new TestCaseData(new FindUserTestCaseData(
                    u => u.UserName == "Amy.Willms56", u => u.Id == 4));

                yield return new TestCaseData(new FindUserTestCaseData(
                    u => u.Contact == "555.275.9032", u => u.Id == 2));

                yield return new TestCaseData(new FindUserTestCaseData(
                    u => u.Id == 10, u => u.UserName == "Marsha.Kihn"));
            }
        }

        private static string GetTestName(
            [CallerMemberName]string baseTestName = null) 
                => baseTestName.Replace("_data", string.Empty);

        public class FindUserTestCaseData
        {
            public FindUserTestCaseData(
                Expression<Func<UserDto, bool>> predicate,
                Expression<Func<UserDto, bool>> expectation)
            {
                Predicate = predicate;
                Expectation = expectation;
            }

            public Expression<Func<UserDto, bool>> Predicate { get; set; }

            public Expression<Func<UserDto, bool>> Expectation { get; set; }

            public override string ToString() => $"{ExpToString(Predicate)}";

            public static string ExpToString<T>(Expression<Func<UserDto, T>> exp)
            {
                var s = exp.Body.ToString();
                return s.Remove(0, s.IndexOf('.') + 1);
            }
        }
    }

    public abstract class RepositoryTestBase
    {
        protected IEnumerable<UserDto> GetSeedData()
        {
            using (StreamReader r = new StreamReader(TestContext.CurrentContext.TestDirectory + @"\Data\UserData.json"))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<List<UserDto>>(json);
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

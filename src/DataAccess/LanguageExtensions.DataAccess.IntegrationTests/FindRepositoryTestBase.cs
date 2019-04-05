using FluentAssertions;
using LanguageExtensions.DataAccess;
using LanguageExtensions.DataAccess.IntegrationTests.Models;
using NUnit.Framework;
using System;
using System.Collections;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using LanguageExtensions.DataAccess.Specifications;

namespace LanguageExtensions.DataAccess.IntegrationTests
{
    public abstract class FindRepositoryTestBase: RepositoryTestBase
    {
        protected abstract IFindRepository<UserDto> GetFindRepository();

        [TestCaseSource(nameof(Should_be_able_to_find_using_expression_data))]
        public async Task Should_be_able_to_find_using_expression(FindUserTestCaseData testCaseData)
        {
            var repository = GetFindRepository();
            var resultFromExpression = await repository.FirstOrDefaultAsync(testCaseData.Predicate).ConfigureAwait(false);
            var resultFromSpecification = await repository.FirstOrDefaultAsync(testCaseData.Predicate.ToSpecification()).ConfigureAwait(false);

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
}

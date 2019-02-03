using LanguageExtensions.DataAccess.IntegrationTests.Models;
using LanguageExtensions.Specifications;
using Newtonsoft.Json;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;

namespace LanguageExtensions.DataAccess.IntegrationTests
{
    public abstract class RepositoryTestBase
    {
        private static Lazy<IEnumerable<UserDto>> _lazyUserSeedData = new Lazy<IEnumerable<UserDto>>(() => LoadUserData(@"\Data\UserData.json"));
        private static Lazy<IEnumerable<UserDto>> _lazyUserSeedData_Set2 = new Lazy<IEnumerable<UserDto>>(() => LoadUserData(@"\Data\UserData_set2.json"));
        private static Lazy<IEnumerable<UserDto>> _lazyUserSeedData_ForInsert = new Lazy<IEnumerable<UserDto>>(() => LoadUserData(@"\Data\UserData_ForInsert.json"));

        private static IEnumerable<UserDto> LoadUserData(string jsonFilePath)
        {
            using (StreamReader r = new StreamReader(TestContext.CurrentContext.TestDirectory + jsonFilePath))
            {
                string json = r.ReadToEnd();
                return JsonConvert.DeserializeObject<List<UserDto>>(json);
            }
        }

        protected static IEnumerable<UserDto> GetSeedUserData() => _lazyUserSeedData.Value;
        protected static IEnumerable<UserDto> GetSeedUserData_Set2() => _lazyUserSeedData_Set2.Value;
        protected static IEnumerable<UserDto> GetSeedUserData_ForInsert() => _lazyUserSeedData_ForInsert.Value;
    }
}

using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace DataAccessSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var dummyUsers = JsonConvert.SerializeObject(GetDummyUsers().Take(10).ToList(), Formatting.Indented);
            //GetDummyUsers().Take(10).ToList().ForEach(Console.WriteLine);
            Console.WriteLine(dummyUsers);
            Console.ReadLine();
        }

        private static IEnumerable<User> GetDummyUsers()
        {
            var ramdom = new Random();
            var faker = new Faker<User>()
                .RuleFor(c => c.Id, c => c.IndexFaker)
                .RuleFor(c => c.FirstName, c => c.Person.FirstName)
                .RuleFor(c => c.LastName, c => c.Person.LastName)
                .RuleFor(c => c.UserName, c => c.Person.UserName)
                .RuleFor(c => c.Email, c => c.Person.Email)
                .RuleFor(c => c.Contact, c => c.Phone.PhoneNumber())
                .RuleFor(c => c.DateOfBirth, c => c.Person.DateOfBirth);

            return faker.GenerateForever();
        }
    }

    public class User
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Contact { get; set; }

        public override string ToString()
        {
            return $"|{string.Join("|", FirstName, LastName, UserName, Email)}|";
        }
    }
}

using FluentAssertions;
using LanguageExtensions.Specifications;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace LanguageExtensions.Tests.Specifications
{
    public class SpecificationTest
    {
        internal class WhiskeySpec : Specification<Drink>
        {
            public override Expression<Func<Drink, bool>> ToExpression() => d => d.Name.ToLower() == "whiskey";
        }

        internal class ColdDrinkSpec : Specification<Drink>
        {
            public override Expression<Func<Drink, bool>> ToExpression() => d => d.With.Any(w => w.ToLower() == "ice");
        }

        [Test]
        public void WhiskeyAndCold()
        {
            // Arrange
            Specification<Drink> whiskeySpec = new WhiskeySpec();
            Specification<Drink> coldSpec = new ColdDrinkSpec();

            // Act
            var coldWhiskeySpec = whiskeySpec.And(coldSpec);

            // Assert
            coldWhiskeySpec.IsSatisfiedBy(Drink.ColdWhiskey()).Should().BeTrue();
            coldWhiskeySpec.IsSatisfiedBy(Drink.AppleJuice()).Should().BeFalse();
        }
        [Test]
        public void WhiskeyAndCold_using_operator()
        {
            // Arrange
            Drink coldWhiskey = Drink.ColdWhiskey();
            Drink appleJuice = Drink.AppleJuice();
            Specification<Drink> whiskeySpec = new WhiskeySpec();
            Specification<Drink> coldSpec = new ColdDrinkSpec();

            // Act
            var coldWhiskeySpec = whiskeySpec & coldSpec;

            // Assert
            coldWhiskeySpec.IsSatisfiedBy(coldWhiskey).Should().BeTrue();
            coldWhiskeySpec.IsSatisfiedBy(appleJuice).Should().BeFalse();
        }
    }



    public class Drink
    {
        public Drink()
        {
            With = new List<String>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime ManufacturedOn { get; set; }

        public List<string> With { get; set; }

        internal static Drink ColdWhiskey(int id = default(int))
        {
            return new Drink
            {
                Id = id,
                Name = "Whiskey",
                With = { "Ice" },
                ManufacturedOn = DateTime.Now.AddYears(-11),
            };
        }

        internal static Drink AppleJuice(int id = default(int))
        {
            return new Drink
            {
                Id = id,
                Name = "Apple Juice",
                With = { "Ice" },
                ManufacturedOn = DateTime.Now.AddMonths(-1),
            };
        }

        internal static Drink OrangeJuice(int id = default(int))
        {
            return new Drink
            {
                Id = id,
                Name = "Orange Juice",
                ManufacturedOn = DateTime.Now.AddMonths(-1),
            };
        }

        internal static Drink BlackberryJuice(int id = default(int))
        {
            return new Drink
            {
                Id = id,
                Name = "Backberry Juice",
                ManufacturedOn = DateTime.Now.AddMonths(-1),
            };
        }
    }
}

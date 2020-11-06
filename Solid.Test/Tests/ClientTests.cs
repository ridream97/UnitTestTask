using NUnit.Framework;
using Solid.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Solid.Test.Tests
{
    [TestFixture]
    class ClientTests
    {
        [TestCase("Ana", 1990, 10)]
        public void CountDiscountTest_BigLoyality(string name, int birthYear, int yearsOfLoyality)
        {
            var client = new Client()
            { 
                Name = name,
                BirthYear = birthYear,
                YearsOfLoyalty = yearsOfLoyality
            };

            var age = DateTime.Now.Year - client.BirthYear;
            var expectedDiscount = client.YearsOfLoyalty > 5 ? age + client.YearsOfLoyalty : age - client.YearsOfLoyalty;

            var actualDiscount = client.CountDiscount();

            Assert.AreEqual(expectedDiscount, actualDiscount);
        }

        [TestCase("Ana", 2, 2001)]
        public void CountDiscountTest_SmallLoyality(string name, int birthYear, int yearsOfLoyality)
        {
            var client = new Client()
            {
                Name = name,
                BirthYear = birthYear,
                YearsOfLoyalty = yearsOfLoyality
            };

            var age = DateTime.Now.Year - client.BirthYear;
            var expectedDiscount = client.YearsOfLoyalty > 5 ? age + client.YearsOfLoyalty : age - client.YearsOfLoyalty;

            var actualDiscount = client.CountDiscount();

            Assert.AreEqual(expectedDiscount, actualDiscount);
        }
    }
}

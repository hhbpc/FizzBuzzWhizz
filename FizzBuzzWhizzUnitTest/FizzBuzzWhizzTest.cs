using System;
using FizzBuzzWhizz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzWhizzUnitTest
{
    [TestClass]
    public class FizzBuzzWhizzTest
    {
        [TestMethod]
        public void Given1ShouldSay1()
        {
            FizzBuzzWhizzMaker maker = new FizzBuzzWhizzMaker(3, 5, 7);
            Assert.AreEqual("1", maker.Translate(1), "Failure - given 1 should say 1 when (3, 5, 7)");
        }

        [TestMethod]
        public void Given3ShouldSayFizz()
        {
            FizzBuzzWhizzMaker maker = new FizzBuzzWhizzMaker(3, 5, 7);
            Assert.AreEqual("Fizz", maker.Translate(3), "Failure - given 3 should say Fizz when (3, 5, 7)");
        }

        [TestMethod]
        public void Given5ShouldSayBuzz()
        {
            FizzBuzzWhizzMaker maker = new FizzBuzzWhizzMaker(3, 5, 7);
            Assert.AreEqual("Buzz", maker.Translate(5), "Failure - given 5 should say Buzz when (3, 5, 7)");
        }

        [TestMethod]
        public void Given7ShouldSayWhizz()
        {
            FizzBuzzWhizzMaker maker = new FizzBuzzWhizzMaker(3, 5, 7);
            Assert.AreEqual("Whizz", maker.Translate(7), "Failure - given 7 should say Whizz when (3, 5, 7)");
        }
    }
}
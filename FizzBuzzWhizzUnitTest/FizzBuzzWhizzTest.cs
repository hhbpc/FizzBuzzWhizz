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
    }
}
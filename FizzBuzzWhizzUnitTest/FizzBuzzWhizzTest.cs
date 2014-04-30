using System;
using FizzBuzzWhizz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzzWhizzUnitTest
{
    [TestClass]
    public class FizzBuzzWhizzTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FizzOutOfRange_1()
        {
            FizzBuzzWhizzMaker maker = new FizzBuzzWhizzMaker(-1, 3, 5);
            Assert.IsNull(maker, "Failure - given fizz out of range should maker null");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FizzOutOfRange_2()
        {
            FizzBuzzWhizzMaker maker = new FizzBuzzWhizzMaker(0, 3, 5);
            Assert.IsNull(maker, "Failure - given fizz out of range should maker null");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void FizzOutOfRange_3()
        {
            FizzBuzzWhizzMaker maker = new FizzBuzzWhizzMaker(10, 3, 5);
            Assert.IsNull(maker, "Failure - given fizz out of range should maker null");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void BuzzOutOfRange_1()
        {
            FizzBuzzWhizzMaker maker = new FizzBuzzWhizzMaker(1, -1, 5);
            Assert.IsNull(maker, "Failure - given buzz out of range should maker null");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void BuzzOutOfRange_2()
        {
            FizzBuzzWhizzMaker maker = new FizzBuzzWhizzMaker(1, 0, 5);
            Assert.IsNull(maker, "Failure - given buzz out of range should maker null");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void BuzzOutOfRange_3()
        {
            FizzBuzzWhizzMaker maker = new FizzBuzzWhizzMaker(1, 10, 5);
            Assert.IsNull(maker, "Failure - given buzz out of range should maker null");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void WhizzOutOfRange_1()
        {
            FizzBuzzWhizzMaker maker = new FizzBuzzWhizzMaker(1, 3, -1);
            Assert.IsNull(maker, "Failure - given whizz out of range should maker null");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void WhizzOutOfRange_2()
        {
            FizzBuzzWhizzMaker maker = new FizzBuzzWhizzMaker(1, 3, 0);
            Assert.IsNull(maker, "Failure - given whizz out of range should maker null");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void WhizzOutOfRange_3()
        {
            FizzBuzzWhizzMaker maker = new FizzBuzzWhizzMaker(1, 3, 10);
            Assert.IsNull(maker, "Failure - given whizz out of range should maker null");
        }

        [TestMethod]
        public void FizzBuzzSame()
        {
            try
            {
                FizzBuzzWhizzMaker maker = new FizzBuzzWhizzMaker(1, 1, 3);
            }
            catch (ArgumentException e)
            {
                StringAssert.Contains(e.ParamName, "buzz");
            }
        }

        [TestMethod]
        public void BuzzFizzSame()
        {
            try
            {
                // 命名参数 Named Arguments
                FizzBuzzWhizzMaker maker = new FizzBuzzWhizzMaker(buzz: 1, fizz: 1, whizz: 3);
            }
            catch (ArgumentException e)
            {
                //StringAssert.Contains(e.ParamName, "fizz");
                StringAssert.Contains(e.ParamName, "buzz");
            }
        }

        [TestMethod]
        public void FizzWhizzSame()
        {
            try
            {
                FizzBuzzWhizzMaker maker = new FizzBuzzWhizzMaker(1, 3, 1);
            }
            catch (ArgumentException e)
            {
                StringAssert.Contains(e.ParamName, "whizz");
            }
        }

        [TestMethod]
        public void BuzzWhizzSame()
        {
            try
            {
                FizzBuzzWhizzMaker maker = new FizzBuzzWhizzMaker(1, 3, 3);
            }
            catch (ArgumentException e)
            {
                StringAssert.Contains(e.ParamName, "whizz");
            }
        }

        [TestMethod]
        public void FizzBuzzWhizzSame()
        {
            try
            {
                FizzBuzzWhizzMaker maker = new FizzBuzzWhizzMaker(1, 1, 1);
            }
            catch (ArgumentException e)
            {
                StringAssert.Contains(e.ParamName, "buzz");
            }
        }

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

        [TestMethod]
        public void Given210ShouldSayFizzBuzzWhizz()
        {
            FizzBuzzWhizzMaker maker = new FizzBuzzWhizzMaker(3, 5, 7);
            Assert.AreEqual("FizzBuzzWhizz", maker.Translate(210), "Failure - given 210 should say FizzBuzzWhizz when (3, 5, 7)");
        }
    }
}
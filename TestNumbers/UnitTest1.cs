using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PositiveNegativeNumbers;


namespace TestNumbers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestIfIsPositiveReturnsTrue()
        {
            Numbers numbers = new Numbers();
            double num = 9;

            bool result = numbers.IsPositive(num);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestIfIsPositiveReturnsFalse()
        {
            Numbers numbers = new Numbers();
            double num = -9;

            bool result = numbers.IsPositive(num);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestIfNumIsZero()
        {
            Numbers numbers = new Numbers();
            double num = 0;

           

            Assert.ThrowsException<ArgumentException>(() => numbers.IsPositive(num));
        }
    }
}

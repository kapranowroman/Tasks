using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1;
using L1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        lab1 obj = new lab1();
        [TestMethod]
        public void validPositive()
        {
            double result = obj.task2(1);
            Assert.AreEqual(4.1887, result, 0.0001);

        }
        [TestMethod]
        public void validPositive2()
        {
            double result = obj.task2(7);
            Assert.AreEqual(1436.7550, result, 0.0001);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void invalidZero()
        {
            double result = obj.task2(0);
            //Assert.AreEqual(4.1887, result, 0.0001);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void invalidNegative()
        {
            double result = obj.task2(-3);
            //Assert.AreEqual(4.1887, result, 0.0001);

        }

    }
}

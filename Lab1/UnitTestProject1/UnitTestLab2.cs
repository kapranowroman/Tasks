using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System.Collections.Generic;

namespace UnitTestProject1
{
    //tests task1
    [TestClass]
    public class l2_t1
    {       
        Lab2Calc obj2 = new Lab2Calc();
        [TestMethod]
        public void test1()
        {
            double result = obj2.task1(-5);
            Assert.AreEqual(5, result, 0.0001);
        }
        [TestMethod]
        public void test2()
        {
            double result = obj2.task1(7);
            Assert.AreEqual(7, result, 0.0001);
        }
        [TestMethod]
        public void test3()
        {
            double result = obj2.task1(0);
            Assert.AreEqual(0, result, 0.0001);
        }
   }
    //tests task2
    [TestClass]
    public class l2_t2
    {
        Lab2Calc obj2 = new Lab2Calc();
        [TestMethod]
        public void test1()
        {
            List<double> result = obj2.task2(6.35,2.7,5.08);
            List<double> otvet = new List<double> { 40.3225,7.29,25.8064 };
            CollectionAssert.AreEqual(otvet, result, new MyComparer());
        }
        [TestMethod]
        public void test2()
        {
            List<double> result = obj2.task2(4.71, 5.59, -18.55);
            List<double> otvet = new List<double> { 22.1841, 31.2481, -18.55 };
            CollectionAssert.AreEqual(otvet, result, new MyComparer());
        }
        [TestMethod]
        public void test3()
        {
            List<double> result = obj2.task2(19.99,-9.57,12.75);
            List<double> otvet = new List<double> { 399.6001, -9.57, 162.5625 };
            CollectionAssert.AreEqual(otvet, result, new MyComparer());
        }
        [TestMethod]
        public void test4()
        {
            List<double> result = obj2.task2(-2.28,16.92,6.14);
            List<double> otvet = new List<double> { -2.28,286.2864,37.6996 };
            CollectionAssert.AreEqual(otvet, result, new MyComparer());
        }
        [TestMethod]
        public void test5()
        {
            List<double> result = obj2.task2(-18.71,-7.6,6.27);
            List<double> otvet = new List<double> { -18.71,-7.6,39.313 };
            CollectionAssert.AreEqual(otvet, result, new MyComparer());
        }
        [TestMethod]
        public void test6()
        {
            List<double> result = obj2.task2(3.44,-14.98,-8.26);
            List<double> otvet = new List<double> { 11.8336,-14.98,-8.26 };
            CollectionAssert.AreEqual(otvet, result, new MyComparer());
        }
        [TestMethod]
        public void test7()
        {
            List<double> result = obj2.task2(-0.09,-16.6,-1.84);
            List<double> otvet = new List<double> { -0.09,-16.6,-1.84 };
            CollectionAssert.AreEqual(otvet, result, new MyComparer());
        }
    }
    //tests task3
    [TestClass]
    public class l2_t3
    {
        Lab2Calc obj2 = new Lab2Calc();
        [TestMethod]
        public void test1()
        {
            bool result = obj2.task3(1,2,3);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void test2()
        {
            bool result = obj2.task3(-4, 0, 5);
            Assert.IsTrue(result);
        }
        [TestMethod]
        public void test3()
        {
            bool result = obj2.task3(7, 4, -2);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void test4()
        {
            bool result = obj2.task3(0, 5, -7);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void test5()
        {
            bool result = obj2.task3(4, 4, 4);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void test6()
        {
            bool result = obj2.task3(-2, 4, 3);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void test7()
        {
            bool result = obj2.task3(10, 3, 5);
            Assert.IsFalse(result);
        }
        [TestMethod]
        public void test8()
        {
            bool result = obj2.task3(5, 1, 7);
            Assert.IsFalse(result);
        }
    }
    //tests task4
    [TestClass]
    public class l2_t4
    {
        Lab2Calc obj2 = new Lab2Calc();
        [TestMethod]
        public void test1()
        {
            List<double> result = obj2.task4(1, 2, 3,4);
            List<double> otvet = new List<double> { 1, 2, 3, 4 };
            CollectionAssert.AreEqual(otvet, result, new MyComparer());
        }
        [TestMethod]
        public void test2()
        {
            List<double> result = obj2.task4(3, 3, 3, 3);
            List<double> otvet = new List<double> { 3, 3, 3, 3 };
            CollectionAssert.AreEqual(otvet, result, new MyComparer());
        }
        [TestMethod]
        public void test3()
        {
            List<double> result = obj2.task4(3, 2, 1, 0);
            List<double> otvet = new List<double> { 9, 4, 1, 0 };
            CollectionAssert.AreEqual(otvet, result, new MyComparer());
        }
        [TestMethod]
        public void test4()
        {
            List<double> result = obj2.task4(19.3,3.5,1.6,-7.4);
            List<double> otvet = new List<double> { 372.49,12.25,2.56,54.76 };
            CollectionAssert.AreEqual(otvet, result, new MyComparer());
        }
        [TestMethod]
        public void test5()
        {
            List<double> result = obj2.task4(3,2,5,4);
            List<double> otvet = new List<double> { 3,2,5,4 };
            CollectionAssert.AreEqual(otvet, result, new MyComparer());
        }
        [TestMethod]
        public void test6()
        {
            List<double> result = obj2.task4(3,5,2,4);
            List<double> otvet = new List<double> { 3,5,2,4 };
            CollectionAssert.AreEqual(otvet, result, new MyComparer());
        }
    }
    //tests task5
    [TestClass]
    public class l2_t5
    {
        Lab2Calc obj2 = new Lab2Calc();
        [TestMethod]
        public void test1()
        {
            List<double> result = obj2.task5(10, 20);
            List<double> otvet = new List<double> { 10, 20 };
            CollectionAssert.AreEqual(otvet, result, new MyComparer());
        }
        [TestMethod]
        public void test2()
        {
            List<double> result = obj2.task5(-5,6);
            List<double> otvet = new List<double> { 5,6 };
            CollectionAssert.AreEqual(otvet, result, new MyComparer());
        }
        [TestMethod]
        public void test3()
        {
            List<double> result = obj2.task5(-3, -15);
            List<double> otvet = new List<double> { 3,15 };
            CollectionAssert.AreEqual(otvet, result, new MyComparer());
        }
        [TestMethod]
        public void test4()
        {
            List<double> result = obj2.task5(3, -8);
            List<double> otvet = new List<double> { 3, 8 };
            CollectionAssert.AreEqual(otvet, result, new MyComparer());
        }
    }
    //tests task6
    [TestClass]
    public class l2_t6
    {
        Lab2Calc obj2 = new Lab2Calc();
        [TestMethod]
        public void test1()
        {
            List<double> result = obj2.task6(3,2,1);
            List<double> otvet = new List<double> {6,4,2 };
            CollectionAssert.AreEqual(otvet, result, new MyComparer());
        }
        [TestMethod]
        public void test2()
        {
            List<double> result = obj2.task6(3,3,3);
            List<double> otvet = new List<double> { 6,6,6 };
            CollectionAssert.AreEqual(otvet, result, new MyComparer());
        }
        [TestMethod]
        public void test3()
        {
            List<double> result = obj2.task6(3, -2,1);
            List<double> otvet = new List<double> { 3,2,1 };
            CollectionAssert.AreEqual(otvet, result, new MyComparer());
        }
        [TestMethod]
        public void test4()
        {
            List<double> result = obj2.task6(0.5,-1.6,7.4);
            List<double> otvet = new List<double> { 0.5,1.6,7.4};
            CollectionAssert.AreEqual(otvet, result, new MyComparer());
        }
    }
    //tests task7
    [TestClass]
    public class l2_t7
    {
        Lab2Calc obj2 = new Lab2Calc();
        [TestMethod]
        public void test1()
        {
            List<double> result = obj2.task7(6.35, 2.7, 5.08);
            List<double> otvet = new List<double> { 2.7};
            CollectionAssert.AreEqual(otvet, result, new MyComparer());
        }
        [TestMethod]
        public void test2()
        {
            List<double> result = obj2.task7(4.71,2.59,-18.55);
            List<double> otvet = new List<double> { 4.71,2.59 };
            CollectionAssert.AreEqual(otvet, result, new MyComparer());
        }
        [TestMethod]
        public void test3()
        {
            List<double> result = obj2.task7(19.99,-1.57,2.75);
            List<double> otvet = new List<double> { -1.57,2.75 };
            CollectionAssert.AreEqual(otvet, result, new MyComparer());
        }
        [TestMethod]
        public void test4()
        {
            List<double> result = obj2.task7(-2.28,16.92,6.14);
            List<double> otvet = new List<double> { -2.28 };
            CollectionAssert.AreEqual(otvet, result, new MyComparer());
        }
    }
    //tests task8
    [TestClass]
    public class l2_t8
    {
        Lab2Calc obj2 = new Lab2Calc();
        [TestMethod]
        public void test1()
        {
            double result = obj2.task8(1,2,3);
            //List<double> otvet = new List<double> { 2.7 };
            Assert.AreEqual(3, result, 0.001);
        }
        [TestMethod]
        public void test2()
        {
            double result = obj2.task8(7,4,-2);
            //List<double> otvet = new List<double> { 2.7 };
            Assert.AreEqual(7, result, 0.001);
        }
        [TestMethod]
        public void test3()
        {
            double result = obj2.task8(0,5,-7);
            //List<double> otvet = new List<double> { 2.7 };
            Assert.AreEqual(5, result, 0.001);
        }

    }
}

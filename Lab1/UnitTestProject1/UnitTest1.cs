using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab1;
using Calculator;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class task1
    {
        lab1Calc obj = new lab1Calc();
        //tests task1
        [TestMethod]
        public void t1ValidPositive()
        {
            double result = obj.task1(1);
            Assert.AreEqual(6.2831, result,0.0001);

        }
        [TestMethod]
        public void t1ValidPositive2()
        {
            double result = obj.task1(5);
            Assert.AreEqual(31.4159, result, 0.0001);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void t1InvalidZero()
        {
            double result = obj.task1(0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void t1InvalidNegative()
        {
            double result = obj.task1(-2);

        }
    }
    //tests task2
    [TestClass]
    public class task2
    {
        lab1Calc obj = new lab1Calc();

        [TestMethod]
        public void t2ValidPositive()
        {

            double result = obj.task2(1);
            Assert.AreEqual(4.1887, result, 0.0001);

        }
        [TestMethod]
        public void t2ValidPositive2()
        {
            double result = obj.task2(7);
            Assert.AreEqual(1436.7550, result, 0.0001);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void t2InvalidZero()
        {
            double result = obj.task2(0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void t2InvalidNegative()
        {
            double result = obj.task2(-3);

        }

    }
    //tests task3
    [TestClass]
    public class task3
    {
        lab1Calc obj = new lab1Calc();

        [TestMethod]
        public void PositiveAH()
        {

            double result = obj.task3(1, 1);
            Assert.AreEqual(0.5, result, 0.0001);

        }
        [TestMethod]
        public void ValidPositiveAH2()
        {
            double result = obj.task3(2, 3);
            Assert.AreEqual(3, result, 0.0001);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidZero()
        {
            double result = obj.task3(0, 10);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidNegative()
        {
            double result = obj.task3(-2, 1);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InvalidNegative2()
        {
            double result = obj.task3(3, -4);

        }

    }
    //tests task4
    [TestClass]
    public class task4
    {
        lab1Calc obj = new lab1Calc();

        [TestMethod]
        public void test1()
        {

            double result = obj.task4(1.5);
            Assert.AreEqual(1, result, 0.0001);

        }
        [TestMethod]
        public void test2()
        {
            double result = obj.task4(9.9);
            Assert.AreEqual(9, result, 0.0001);

        }
        [TestMethod]
        public void test3()
        {
            double result = obj.task4(-0.5);
            Assert.AreEqual(0, result, 0.0001);

        }
        [TestMethod]
        public void test4()
        {
            double result = obj.task4(-15.7);
            Assert.AreEqual(-15, result, 0.0001);

        }
        [TestMethod]
        public void test5()
        {
            double result = obj.task4(7);
            Assert.AreEqual(7, result, 0.0001);

        }
        [TestMethod]
        public void test6()
        {
            double result = obj.task4(-11);
            Assert.AreEqual(-11, result, 0.0001);

        }


    }
    //tests task5
    [TestClass]
    public class task5
    {
        lab1Calc obj = new lab1Calc();

        [TestMethod]
        public void test1()
        {

            double result = obj.task5(45);
            Assert.AreEqual(0.7853, result, 0.0001);

        }
        [TestMethod]
        public void test2()
        {
            double result = obj.task5(0);
            Assert.AreEqual(0, result, 0.0001);

        }
        [TestMethod]
        public void test3()
        {
            double result = obj.task5(360);
            Assert.AreEqual(0, result, 0.0001);

        }
        [TestMethod]
        public void test4()
        {
            double result = obj.task5(90);
            Assert.AreEqual(1.5707, result, 0.0001);

        }
        [TestMethod]
        public void test5()
        {
            double result = obj.task5(-90);
            Assert.AreEqual(4.7123, result, 0.0001);

        }
        [TestMethod]
        public void test6()
        {
            double result = obj.task5(-270);
            Assert.AreEqual(1.5707, result, 0.0001);

        }
    }
    //tests task6
    [TestClass]
    public class task6
    {
        lab1Calc obj = new lab1Calc();

        [TestMethod]
        public void test1()
        {

            double result = obj.task6(1, 1, 3, 4);
            Assert.AreEqual(3.605, result, 0.001);

        }
        [TestMethod]
        public void test2()
        {
            double result = obj.task6(-2, 4, 8, -10);
            Assert.AreEqual(17.2046, result, 0.0001);

        }
        [TestMethod]
        public void test3()
        {
            double result = obj.task6(0, 0, -5, -7);
            Assert.AreEqual(8.6023, result, 0.0001);

        }
        [TestMethod]
        public void test4()
        {
            double result = obj.task6(0, 0, 0, 0);
            Assert.AreEqual(0, result, 0.0001);

        }
        [TestMethod]
        public void test5()
        {
            double result = obj.task6(-1, -3, 2, 9);
            Assert.AreEqual(12.3693, result, 0.0001);

        }
    }



        //tests task7
        [TestClass]
    
        public class task7
        {
            lab1Calc obj = new lab1Calc();

            [TestMethod]
            public void test1()
            {
                List<double> result = obj.task7(1, 30, 3, 20);
                List<double> otvet = new List<double> { 4, 22.5 };
                CollectionAssert.AreEqual(otvet, result);
             }
            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void test2InvalidV1()
            {
                List<double> result = obj.task7(-2, 10, 5, 50);
            }
            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void test3InvalidV2()
            {
                List<double> result = obj.task7(4, 100, -10, 4);
            }
            [TestMethod]
            public void test4()
            {
                List<double> result = obj.task7(1, -20, 10, 20);
                List<double> otvet = new List<double> { 11, 16.3636 };
                CollectionAssert.AreEqual(otvet, result, new MyComparer());
            }
            [TestMethod]
            public void test5()
            {
                List<double> result = obj.task7(5, 90, 1, -10);
                List<double> otvet = new List<double> { 6, 73.3333 };
                CollectionAssert.AreEqual(otvet, result, new MyComparer());
            }
            
        }

        //tests task8+9
        [TestClass]

        public class task8_9
        {
            lab1Calc obj = new lab1Calc();

            [TestMethod]
            public void test1ValidA()
            {
                List<double> result = obj.task8_9(1);
                List<double> otvet = new List<double> { 1, 6 };
                CollectionAssert.AreEqual(otvet, result, new MyComparer());
            }
            [TestMethod]
            public void test2ValidA()
            {
                List<double> result = obj.task8_9(5);
                List<double> otvet = new List<double> { 125, 150 };
                CollectionAssert.AreEqual(otvet, result, new MyComparer());
            }
            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void test3ZeroA()
            {
                List<double> result = obj.task8_9(0);
                
            }
            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void test4NegativeA()
            {
                List<double> result = obj.task8_9(-2);
                
            }
            

        }

        //tests task10
        [TestClass]

        public class task10
        {
            lab1Calc obj = new lab1Calc();

            [TestMethod]
            public void test1Valid()
            {
                List<int> result = obj.task10(0,0,2,3);
                List<int> otvet = new List<int> { 3, 2 };
                CollectionAssert.AreEqual(otvet, result);
            }
            [TestMethod]
            public void test2Valid()
            {
                List<int> result = obj.task10(0, 0, 1, 1);
                List<int> otvet = new List<int> { 1, 1 };
                CollectionAssert.AreEqual(otvet, result);
            }
            [TestMethod]
            public void test3Valid()
            {
                List<int> result = obj.task10(219, 374, 51, 96);
                List<int> otvet = new List<int> { 315, 425 };
                CollectionAssert.AreEqual(otvet, result);
            }
            
            
            
            
            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void test4ZeroH()
            {
                List<int> result = obj.task10(2,2,0,3);

            }
            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void test5NegativeH()
            {
                List<int> result = obj.task10(2,2,-1,3);

            }
            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void test6ZeroW()
            {
                List<int> result = obj.task10(2, 2, 3,0);

            }
            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void test7NegativeW()
            {
                List<int> result = obj.task10(2, 2,3,-1);

            }

        }
    
}

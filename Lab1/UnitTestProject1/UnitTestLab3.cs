using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System.Collections.Generic;

namespace UnitTestProject1
{
    //task1
    [TestClass]
    public class L3_T1
    {
        Lab3Calc obj3 = new Lab3Calc();
        [TestMethod]
        public void Test1()
        {
            string result = obj3.task1(8, 13);
            string otvet = "";
            for (int i = 8; i <= 13; i++)
            {
                otvet += i + "\n";
            }
            Assert.AreEqual(otvet, result);
        }
        [TestMethod]
        public void Test2()
        {
            string result = obj3.task1(691, 702);
            string otvet = "";
            for (int i = 691; i <= 702; i++) { otvet += i + "\n"; }
            Assert.AreEqual(otvet, result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test3()
        {
            string result = obj3.task1(3000, 24);
            //List<int> otvet = new List<int>();
            //for (int i = 8; i <= 13; i++) { otvet.Add(i); }
            //CollectionAssert.AreEqual(otvet, result);
        }
    }
    //task2
    [TestClass]
    public class L3_T2
    {
        Lab3Calc obj3 = new Lab3Calc();
        [TestMethod]
        public void Test1()
        {
            string result = obj3.task2(8, 13);
            string otvet = "";
            for (int i = 13; i >= 8; i--) { otvet += i + " "; }
            Assert.AreEqual(otvet, result);
        }
        [TestMethod]
        public void Test2()
        {
            string result = obj3.task2(691, 703);
            string otvet = "";
            for (int i = 703; i >= 691; i--) { otvet += i + " "; }
            Assert.AreEqual(otvet, result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test3()
        {
            string result = obj3.task2(3000, 24);
        }
    }
    //task3
    [TestClass]
    public class L3_T3
    {
        Lab3Calc obj3 = new Lab3Calc();
        [TestMethod]
        public void Test1()
        {
            string result = obj3.task3(8, '#');
            string otvet = "\"";
            for (int i = 0; i < 8; i++) { otvet += '#'; }
            otvet += "\"";
            Assert.AreEqual(otvet, result);
        }
        [TestMethod]
        public void Test2()
        {
            string result = obj3.task3(15, ' ');
            string otvet = "\"";
            for (int i = 0; i < 15; i++) { otvet += ' '; }
            otvet += "\"";
            Assert.AreEqual(otvet, result);
        }
        [TestMethod]
        public void Test3()
        {
            string result = obj3.task3(0, '?');
            string otvet = "\"";
            for (int i = 0; i < 0; i++) { otvet += '?'; }
            otvet += "\"";
            Assert.AreEqual(otvet, result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test4InvalidA()
        {
            string result = obj3.task3(-1, '*');

        }
    }
    //task4
    [TestClass]
    public class L3_T4
    {
        Lab3Calc obj3 = new Lab3Calc();
        [TestMethod]
        public void Test1()
        {
            int result = obj3.task4();
            Assert.AreEqual(119800, result);
        }
    }
    //task5
    [TestClass]
    public class L3_T5
    {
        Lab3Calc obj3 = new Lab3Calc();
        [TestMethod]
        public void Test1()
        {
            int result = obj3.task5(-100);
            Assert.AreEqual(120200, result);
        }
        [TestMethod]
        public void Test2()
        {
            int result = obj3.task5(7);
            Assert.AreEqual(125229, result);
        }
        [TestMethod]
        public void Test3()
        {
            int result = obj3.task5(368);
            Assert.AreEqual(57722, result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test4InvalidA()
        {
            int result = obj3.task5(1001);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test4InvalidA2()
        {
            int result = obj3.task5(-101);
        }
    }
    //task6
    [TestClass]
    public class L3_T6
    {
        Lab3Calc obj3 = new Lab3Calc();
        [TestMethod]
        public void Test1()
        {
            int result = obj3.task6(12);
            Assert.AreEqual(23, result);
        }
        [TestMethod]
        public void Test2()
        {
            int result = obj3.task6(70);
            Assert.AreEqual(2430, result);
        }
        [TestMethod]
        public void Test3()
        {
            int result = obj3.task6(368);
            Assert.AreEqual(67841, result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test4InvalidB()
        {
            int result = obj3.task6(-11);
        }
    }
    //task7
    [TestClass]
    public class L3_T7
    {
        Lab3Calc obj3 = new Lab3Calc();
        [TestMethod]
        public void Test1()
        {
            int result = obj3.task7(15, 27);
            Assert.AreEqual(273, result);
        }
        [TestMethod]
        public void Test2()
        {
            int result = obj3.task7(25, 44);
            Assert.AreEqual(690, result);
        }
        [TestMethod]
        public void Test3()
        {
            int result = obj3.task7(80, 100);
            Assert.AreEqual(1890, result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test4Invalid()
        {
            int result = obj3.task7(3000, 24);
        }
    }
    //task8
    [TestClass]
    public class L3_T8
    {
        Lab3Calc obj3 = new Lab3Calc();
        [TestMethod]
        public void Test1()
        {
            int result = obj3.task8(8, 13);
            Assert.AreEqual(1235520, result);
        }
        [TestMethod]
        public void Test2()
        {
            int result = obj3.task8(158.5, 161.3);
            Assert.AreEqual(4095840, result);
        }
        [TestMethod]
        public void Test3()
        {
            int result = obj3.task8(648, 648);
            Assert.AreEqual(419904, result);
        }
        [TestMethod]
        public void Test4()
        {
            int result = obj3.task8(-2, 600);
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test5Invalid()
        {
            int result = obj3.task8(3000, 24);
        }
    }
    //task9
    [TestClass]
    public class L3_T9
    {
        Lab3Calc obj3 = new Lab3Calc();
        [TestMethod]
        public void Test1()
        {
            int result = obj3.task9(8, 13);
            Assert.AreEqual(0, result);
        }
        [TestMethod]
        public void Test2()
        {
            int result = obj3.task9(25, 44);
            Assert.AreEqual(105, result);
        }
        [TestMethod]
        public void Test3()
        {
            int result = obj3.task9(80, 100);
            Assert.AreEqual(273, result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test4Invalid()
        {
            int result = obj3.task9(3000, 24);
        }
    }
    //task10
    [TestClass]
    public class L3_T10
    {
        Lab3Calc obj3 = new Lab3Calc();
        [TestMethod]
        public void Test1()
        {
            int result = obj3.task10();
            Assert.AreEqual(69, result);
        }
    }
    //task11
    [TestClass]
    public class L3_T11
    {
        Lab3Calc obj3 = new Lab3Calc();
        [TestMethod]
        public void Test1()
        {
            int result = obj3.task11();
            Assert.AreEqual(636300, result);
        }
    }
    //task12
    [TestClass]
    public class L3_T12
    {
        Lab3Calc obj3 = new Lab3Calc();
        [TestMethod]
        public void Test1()
        {
            int result = obj3.task12(15, 27);
            Assert.AreEqual(5915, result);
        }
        [TestMethod]
        public void Test2()
        {
            int result = obj3.task12(25, 44);
            Assert.AreEqual(24470, result);
        }
        [TestMethod]
        public void Test3()
        {
            int result = obj3.task12(80, 100);
            Assert.AreEqual(170870, result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test4()
        {
            int result = obj3.task12(3000, 24);

        }
    }
    //task13
    [TestClass]
    public class L3_T13
    {
        Lab3Calc obj3 = new Lab3Calc();
        [TestMethod]
        public void Test1()
        {
            string result = obj3.task13('#', 5, 3);
            string TrueResult = "#####\n#####\n#####";
            Assert.AreEqual(TrueResult, result);
        }
        [TestMethod]
        public void Test2()
        {
            string result = obj3.task13('?', 7, 10);
            string TrueResult = "???????\n???????\n???????\n???????\n???????\n???????\n???????\n???????\n???????\n???????";
            Assert.AreEqual(TrueResult, result);
        }
        [TestMethod]
        public void Test3()
        {
            string result = obj3.task13('*', 90, 0);
            string TrueResult = "";
            Assert.AreEqual(TrueResult, result);
        }
        [TestMethod]
        public void Test4()
        {
            string result = obj3.task13('=', 0, 15);
            string TrueResult = "";
            Assert.AreEqual(TrueResult, result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test5()
        {
            string result = obj3.task13('o', -2, 8);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test6()
        {
            string result = obj3.task13('!', 20, -6);
        }

    }
    //task14
    [TestClass]
    public class L3_T14
    {
        Lab3Calc obj3 = new Lab3Calc();
        [TestMethod]
        public void Test1()
        {
            string result = obj3.task14('#', 6);
            string TrueResult = "#\n##\n###\n####\n#####\n######";
            Assert.AreEqual(TrueResult, result);
        }
        [TestMethod]
        public void Test2()
        {
            string result = obj3.task14('\\', 3);
            string TrueResult = @"\" + "\n" + @"\\" + "\n" + @"\\\";
            Assert.AreEqual(TrueResult, result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test3()
        {
            string result = obj3.task14('0', -2);
        }
        [TestMethod]
        public void Test4()
        {
            string result = obj3.task14('^', 0);
            string TrueResult ="";
            Assert.AreEqual(TrueResult, result);
        }
    }
    //task15
    [TestClass]
    public class L3_T15
    {
        Lab3Calc obj3 = new Lab3Calc();
        [TestMethod]
        public void Test1()
        {
            string result = obj3.task15(8,13);
            string TrueResult = "9\n 11\n  13";
            Assert.AreEqual(TrueResult, result);
        }
        [TestMethod]
        public void Test2()
        {
            string result = obj3.task15(691, 703);
            string TrueResult = "691\n 693\n  695\n   697\n    699\n     701\n      703";
            Assert.AreEqual(TrueResult, result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test3()
        {
            string result = obj3.task15(3000, 24);
            
        }
    }
    //task16
    [TestClass]
    public class L3_T16
    {
        Lab3Calc obj3 = new Lab3Calc();
        [TestMethod]
        public void Test1()
        {
            string result = obj3.task16('#', '0', 5, 3);
            string TrueResult = "#####\n00000\n#####";
            Assert.AreEqual(TrueResult, result);
        }
        [TestMethod]
        public void Test2()
        {
            string result = obj3.task16('?', '-', 7, 10);
            string TrueResult = "???????\n-------\n???????\n-------\n???????\n-------\n???????\n-------\n???????\n-------";
            Assert.AreEqual(TrueResult, result);
        }
        [TestMethod]
        public void Test3()
        {
            string result = obj3.task16('*', '!', 90, 0);
            string TrueResult = "";
            Assert.AreEqual(TrueResult, result);
        }
        [TestMethod]
        public void Test4()
        {
            string result = obj3.task16('=', '+',0, 15);
            string TrueResult = "";
            Assert.AreEqual(TrueResult, result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test5InvlidW()
        {
            string result = obj3.task16('o', 'T', -2, 8);
            
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test5InvlidH()
        {
            string result = obj3.task16('!', '.', 20, -6);

        }
    }
    //task17
    [TestClass]
    public class L3_T17
    {
        Lab3Calc obj3 = new Lab3Calc();
        [TestMethod]
        public void Test1()
        {
            string result = obj3.task17(8, 13);
            string TrueResult = "9,11,13";
            Assert.AreEqual(TrueResult, result);
        }
        [TestMethod]
        public void Test2()
        {
            string result = obj3.task17(691, 703);
            string TrueResult = "691,693,695,697,699,701,703";
            Assert.AreEqual(TrueResult, result);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test3Invalid()
        {
            string result = obj3.task17(3000, 24);
        }
    }
}


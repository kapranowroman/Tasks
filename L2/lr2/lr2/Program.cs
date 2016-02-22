using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Лабораторная 2, задача 1

            T1 test1_1 = new T1(-5, 5);
            Console.WriteLine(test1_1);
            T1 test1_2 = new T1(7,7);
            Console.WriteLine(test1_2);
            T1 test1_3 = new T1(0,0);
            Console.WriteLine(test1_3);

            Console.WriteLine();
            Console.WriteLine("------------//-----------");
            Console.WriteLine();

            //Лабораторная 2, задача 2

            T2 test2_1 = new T2(6.35, 2.7, 5.08, 40.3225, 7.29, 25.8064);
            Console.WriteLine(test2_1);
            T2 test2_2 = new T2(4.71,5.59,-18.55,22.1841,31.2481,-18.55);
            Console.WriteLine(test2_2);
            T2 test2_3 = new T2(19.99,-9.57,12.75,399.6001,-9.57,162.5625);
            Console.WriteLine(test2_3);
            T2 test2_4 = new T2(-2.28,16.92,6.14,-2.28,286.2864,37.6996);
            Console.WriteLine(test2_4);
            T2 test2_5 = new T2(-18.71,-7.6,6.27,-18.71,-7.6,39.31);
            Console.WriteLine(test2_5);
            T2 test2_6 = new T2(3.44,-14.98,-8.26,11.8336,-14.98,-8.26);
            Console.WriteLine(test2_6);
            T2 test2_7 = new T2(-0.09,-16.6,-1.84,-0.09,-16.6,-1.84);
            Console.WriteLine(test2_7);


            Console.WriteLine();
            Console.WriteLine("------------//-----------");
            Console.WriteLine();

            //Лабораторная 2, задача 3
            T3 test3_1 = new T3(1, 2, 3, "True");
            Console.WriteLine(test3_1);
            T3 test3_2 = new T3(-4, 0, 5, "True");
            Console.WriteLine(test3_2);
            T3 test3_3 = new T3(7, 4, -2, "False");
            Console.WriteLine(test3_3);
            T3 test3_4 = new T3(0, 5, -7, "False");
            Console.WriteLine(test3_4);
            T3 test3_5 = new T3(4, 4, 4, "False");
            Console.WriteLine(test3_5);
            T3 test3_6 = new T3(-2, 4, 3, "False");
            Console.WriteLine(test3_6);
            T3 test3_7 = new T3(10, 3, 5, "False");
            Console.WriteLine(test3_7);
            T3 test3_8 = new T3(5, 1, 7, "False");
            Console.WriteLine(test3_8);


            Console.WriteLine();
            Console.WriteLine("------------//-----------");
            Console.WriteLine();

            //Лабораторная 2, задача 4

            T4 test4_1 = new T4(1,2,3,4,"1 2 3 4");
            Console.WriteLine(test4_1);
            T4 test4_2 = new T4(3,3,3,3, "3 3 3 3");
            Console.WriteLine(test4_2);
            T4 test4_3 = new T4(3,2,1,0, "9 4 1 0");
            Console.WriteLine(test4_3);
            T4 test4_4 = new T4(19.3,3.5,1.6,-7.4,"378.49  12.25  2.56  54.76");
            Console.WriteLine(test4_4);
            T4 test4_5 = new T4(3,2,5,4,"3 2 5 4");
            Console.WriteLine(test4_5);
            T4 test4_6 = new T4(3,5,2,4,"3 5 2 4");
            Console.WriteLine(test4_6);


            Console.WriteLine();
            Console.WriteLine("------------//-----------");
            Console.WriteLine();

            //Лабораторная 2, задача 5

            T5 test5_1 = new T5(10,20,"10  20");
            Console.WriteLine(test5_1);
            T5 test5_2 = new T5(-5,6,"5  6");
            Console.WriteLine(test5_2);
            T5 test5_3 = new T5(-3, -15, "3 15");
            Console.WriteLine(test5_3);
            T5 test5_4 = new T5(3, -8, "3  8");
            Console.WriteLine(test5_4);

            Console.WriteLine();
            Console.WriteLine("------------//-----------");
            Console.WriteLine();

            //Лабораторная 2, задача 6
            T6 test6_1 = new T6(3,2,1," 6 4 2");
            Console.WriteLine(test6_1);
            T6 test6_2 = new T6(3,3,3,"6 6 6");
            Console.WriteLine(test6_2);
            T6 test6_3 = new T6(3,-2,1,"3 2 1");
            Console.WriteLine(test6_3);
            T6 test6_4 = new T6(0.5,-1.6,7.4,"0.5 1.6 7.4");
            Console.WriteLine(test6_4);


            Console.WriteLine();
            Console.WriteLine("------------//-----------");
            Console.WriteLine();

            //Лабораторная 2, задача 7
            
            T7 test7_1 = new T7(6.35,2.7,5.08, " 2.7");
            Console.WriteLine(test7_1);
            T7 test7_2 = new T7(4.71,2.59,-18.55, "4.71, 2.59");
            Console.WriteLine(test7_2);
            T7 test7_3 = new T7(19.99,-1.57,2.75, "-1.57, 2.75");
            Console.WriteLine(test7_3);
            T7 test7_4 = new T7(-2.28, 16.92, 6.14, " -2.28");
            Console.WriteLine(test7_4);

            Console.WriteLine();
            Console.WriteLine("------------//-----------");
            Console.WriteLine();

            //Лабораторная 2, задача 8
            T8 test8_1 = new T8(1,2,3, "3");
            Console.WriteLine(test8_1);
            T8 test8_2 = new T8(7,4,-2, "7");
            Console.WriteLine(test8_2);
            T8 test8_3 = new T8(0,5,-7,"5");
            Console.WriteLine(test8_3);


            Console.ReadKey();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Лабораторная 1, задача 4
            T4 test4_1 = new T4 (1.5);
            Console.WriteLine("-----------------Задача 4, тест 1, ожидаемый рез-т: 1-----------");
            Console.WriteLine(test4_1);
            
            T4 test4_2 = new T4(9.9);
            Console.WriteLine("-----------------Задача 4, тест 2, ожидаемый рез-т: 9-----------");
            Console.WriteLine(test4_2);
           
            T4 test4_3 = new T4(-0.5);
            Console.WriteLine("-----------------Задача 4, тест 3, ожидаемый рез-т: 0-----------");
            Console.WriteLine(test4_3);
            
            T4 test4_4 = new T4(-15.7);
            Console.WriteLine("-----------------Задача 4, тест 4, ожидаемый рез-т: -15-----------");
            Console.WriteLine(test4_4);
            
            T4 test4_5 = new T4(7);
            Console.WriteLine("-----------------Задача 4, тест 5, ожидаемый рез-т: 7-----------");
            Console.WriteLine(test4_5);
           
            T4 test4_6 = new T4(-11);
            Console.WriteLine("-----------------Задача 4, тест 6, ожидаемый рез-т: -11-----------");
            Console.WriteLine(test4_6);
            
            Console.WriteLine();
            Console.WriteLine("------------//-----------");
            Console.WriteLine();

            //Лабораторная 1, задача 5

            T5 test5_1 = new T5 (45);
            Console.WriteLine("-----------------Задача 5, тест 1, ожидаемый рез-т: 0,7853 -----------");
            Console.WriteLine(test5_1);

            T5 test5_2 = new T5(0);
            Console.WriteLine("-----------------Задача 5, тест 2, ожидаемый рез-т: 0 -----------");
            Console.WriteLine(test5_2);

            T5 test5_3 = new T5(360);
            Console.WriteLine("-----------------Задача 5, тест 3, ожидаемый рез-т: 0 -----------");
            Console.WriteLine(test5_3);

            T5 test5_4 = new T5(90);
            Console.WriteLine("-----------------Задача 5, тест 4, ожидаемый рез-т: 1,5707 -----------");
            Console.WriteLine(test5_4);

            T5 test5_5 = new T5(-90);
            Console.WriteLine("-----------------Задача 5, тест 5, ожидаемый рез-т: 4,7123 -----------");
            Console.WriteLine(test5_5);

            T5 test5_6 = new T5(-270);
            Console.WriteLine("-----------------Задача 5, тест 6, ожидаемый рез-т: 1,5707 -----------");
            Console.WriteLine(test5_6);

            Console.WriteLine();
            Console.WriteLine("------------//-----------");
            Console.WriteLine();

            //Лабораторная 1, задача 6

            T6 test6_1 = new T6(1, 1, 3, 4, 3.605);
            Console.WriteLine(test6_1);
            
            T6 test6_2 = new T6(-2, 4, 8, -10, 17.2046);
            Console.WriteLine(test6_2);

            T6 test6_3 = new T6(0, 0, -5, -7, 8.6023);
            Console.WriteLine(test6_3);

            T6 test6_4 = new T6(0, 0, 0, 0, 0);
            Console.WriteLine(test6_4);

            T6 test6_5 = new T6(-1, -3, 2, 9, 12.3693);
            Console.WriteLine(test6_5);

            Console.WriteLine();
            Console.WriteLine("------------//-----------");
            Console.WriteLine();

            //Лабораторная 1, задача 7
            T7 test7_1 = new T7(1,30,3,20,"4","22.5");
            Console.WriteLine(test7_1);

            T7 test7_2 = new T7(-2,10,5,50,"Ошибка", "Ошибка");
            Console.WriteLine(test7_2);

            T7 test7_3 = new T7(4, 100, -10, 4, "Ошибка", "Ошибка");
            Console.WriteLine(test7_3);

            T7 test7_4 = new T7(1,-20,10,20,"11","16.3636");
            Console.WriteLine(test7_4);

            T7 test7_5 = new T7(5,90,1,-10,"6","73.3333");
            Console.WriteLine(test7_5);

            Console.WriteLine();
            Console.WriteLine("------------//-----------");
            Console.WriteLine();
            //Лабораторная 1, задачи 8-9
            T8_T9 test8_1 = new T8_T9(1,"1","6");
            Console.WriteLine(test8_1);
            T8_T9 test8_2 = new T8_T9(5,"125","150");
            Console.WriteLine(test8_2);
            T8_T9 test8_3 = new T8_T9(0,"error","error");
            Console.WriteLine(test8_3);
            T8_T9 test8_4 = new T8_T9(-2,"error","error");
            Console.WriteLine(test8_4);

            Console.WriteLine();
            Console.WriteLine("------------//-----------");
            Console.WriteLine();
            //Лабораторная 1, задача 10
            T10 test10_1 = new T10(0,0,2,3,"3","2");
            Console.WriteLine(test10_1);
            T10 test10_2 = new T10(0, 0, 1, 1, "1", "1");
            Console.WriteLine(test10_2);
            T10 test10_3 = new T10(219, 374, 51, 96, "315", "425");
            Console.WriteLine(test10_3);
            T10 test10_4 = new T10(2, 2, 0, 3, "Error", "Error");
            Console.WriteLine(test10_4);
            T10 test10_5 = new T10(2, 2, -1, 3, "Error", "Error");
            Console.WriteLine(test10_5);
            T10 test10_6 = new T10(2, 2, 3, 0, "Error", "Error");
            Console.WriteLine(test10_6);
            T10 test10_7 = new T10(2, 2, 3, -1, "Error", "Error");
            Console.WriteLine(test10_7);

            Console.WriteLine();
            Console.WriteLine("------------//-----------");
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

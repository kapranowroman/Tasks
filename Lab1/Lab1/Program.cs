using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L1;


namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rep = true;
            while (rep == true)
            {
                Console.WriteLine("Выберите номер лабораторной работы: 1-2.");
                int numberLab;
                Int32.TryParse(Console.ReadLine(), out numberLab);
                int numberTask;


                //словарь с задачами
                Dictionary<int, ILab1Executor> Executors = new Dictionary<int, ILab1Executor>();
                Executors.Add(1, new L1task1());
                Executors.Add(2, new L1task2());
                Executors.Add(3, new L1task3());

                switch (numberLab)
                {
                        
                   
                    case 1:
                        lab1Calc Laba1 = new lab1Calc();
                        Console.WriteLine("Введите номер задачи 1-10");
                        Int32.TryParse(Console.ReadLine(), out numberTask);
                        
                        if (Executors.ContainsKey(numberTask)) 
                        {
                            ILab1Executor Temp = Executors[numberTask];
                            Temp.Execute(Laba1);
                        }


 
                        
                        if (numberTask == 4)
                        {
                            double R;
                            Console.WriteLine("Введите число");
                            double.TryParse(Console.ReadLine(), out R);
                            Console.WriteLine("Ответ:  " + Laba1.task4(R));

                        }
                        if (numberTask == 5)
                        {
                            double R;
                            Console.WriteLine("Введите значение угла в градусах");
                            double.TryParse(Console.ReadLine(), out R);
                            Console.WriteLine("Угол в радианах:  " + Laba1.task5(R));
                        }
                        if (numberTask == 6)
                        {
                            int X1;
                            int Y1;
                            int X2;
                            int Y2;

                            Console.WriteLine("Введите X1");
                            int.TryParse(Console.ReadLine(), out X1);
                            Console.WriteLine("Введите Y1");
                            int.TryParse(Console.ReadLine(), out Y1);
                            Console.WriteLine("Введите X2");
                            int.TryParse(Console.ReadLine(), out X2);
                            Console.WriteLine("Введите Y2");
                            int.TryParse(Console.ReadLine(), out Y2);
                            Console.WriteLine("Расстояние между точками:  " + Laba1.task6(X1,Y1,X2,Y2));

                        }
                        if (numberTask == 7)
                        {
                            double V1;
                            double T1;
                            double V2;
                            double T2;
                            

                            Console.WriteLine("Введите V1");
                            double.TryParse(Console.ReadLine(), out V1);
                            Console.WriteLine("Введите T1");
                            double.TryParse(Console.ReadLine(), out T1);
                            Console.WriteLine("Введите V2");
                            double.TryParse(Console.ReadLine(), out V2);
                            Console.WriteLine("Введите T2");
                            double.TryParse(Console.ReadLine(), out T2);
                            Console.WriteLine("Объем:  " + Laba1.task7(V1, T1, V2, T2)[0] + "   Температура:  " + Laba1.task7(V1, T1, V2, T2)[1]);
                        }
                        if (numberTask == 8)
                        {
                            double a;
                            Console.WriteLine("Введите длину грани куба");
                            double.TryParse(Console.ReadLine(), out a);

                            Console.WriteLine("Объем куба:  " + Laba1.task8_9(a)[0]);
                        }
                        if (numberTask == 9)
                        {
                            double a;
                            Console.WriteLine("Введите длину грани куба");
                            double.TryParse(Console.ReadLine(), out a);

                            Console.WriteLine("Площадь боковой грани:  " + Laba1.task8_9(a)[1]);
                        }
                        if (numberTask == 10)
                        {
                            int X1;
                            int Y1;
                            int H;
                            int W;
                            Console.WriteLine("Введите X1");
                            int.TryParse(Console.ReadLine(), out X1);
                            Console.WriteLine("Введите Y1");
                            int.TryParse(Console.ReadLine(), out Y1);
                            Console.WriteLine("Введите H");
                            int.TryParse(Console.ReadLine(), out H);
                            Console.WriteLine("Введите W");
                            int.TryParse(Console.ReadLine(), out W);

                            try
                            {
                                Console.WriteLine("Координаты нижнего правого угла:  " + Laba1.task10(X1, Y1, H, W)[0] + "; " + Laba1.task10(X1, Y1, H, W)[1]);
                            }
                            catch (ArgumentException)
                            {
                                Console.WriteLine("Одно из введенных значений не корректно");
                            }
                        }




                        break;
                    case 2:
                        Lab2 Laba2 = new Lab2();
                        Console.WriteLine("Введите номер задачи 1-10");
                        Int32.TryParse(Console.ReadLine(), out numberTask);

                        if (numberTask == 1)
                        {
                            Console.WriteLine("Введите число А");
                            double A;
                            double.TryParse(Console.ReadLine(), out A);
                            Console.WriteLine("Абсолютное значение:  " + Laba2.task1(A));
                        }
                        if (numberTask == 2)
                        {
                            double X;
                            double Y;
                            double Z;
                            Console.WriteLine("Введите X");
                            double.TryParse(Console.ReadLine(), out X);
                            Console.WriteLine("Введите Y");
                            double.TryParse(Console.ReadLine(), out Y);
                            Console.WriteLine("Введите Z");
                            double.TryParse(Console.ReadLine(), out Z);
                            Console.WriteLine("X: " + Laba2.task2(X, Y, Z)[0] + "    Y: " + Laba2.task2(X, Y, Z)[1]+ "   Z: " + Laba2.task2(X, Y, Z)[2]);
                        
                        }
                        if (numberTask == 3)
                        {
                            double a;
                            double b;
                            double c;
                            Console.WriteLine("Введите a");
                            double.TryParse(Console.ReadLine(), out a);
                            Console.WriteLine("Введите b");
                            double.TryParse(Console.ReadLine(), out b);
                            Console.WriteLine("Введите c");
                            double.TryParse(Console.ReadLine(), out c);
                            if (Laba2.task3(a, b, c) == true) { Console.WriteLine("Выполняется"); }
                            if (Laba2.task3(a, b, c) == false) { Console.WriteLine("Не выполняется"); }
                            
                        }
                        if (numberTask == 4)
                        {
                            double a;
                            double b;
                            double c;
                            double d;
                            Console.WriteLine("Введите a");
                            double.TryParse(Console.ReadLine(), out a);
                            Console.WriteLine("Введите b");
                            double.TryParse(Console.ReadLine(), out b);
                            Console.WriteLine("Введите c");
                            double.TryParse(Console.ReadLine(), out c);
                            Console.WriteLine("Введите d");
                            double.TryParse(Console.ReadLine(), out d);
                            List<double>result=Laba2.task4(a, b, c,d);
                            Console.WriteLine("a: " + result[0] + "    b: " + result[1] + "   c: " + result[2]+"  d:  "+ result[3]);

                        }
                        if (numberTask == 5)
                        {
                            double X;
                            double Y;
                            
                            Console.WriteLine("Введите X");
                            double.TryParse(Console.ReadLine(), out X);
                            Console.WriteLine("Введите Y");
                            double.TryParse(Console.ReadLine(), out Y);
                                                
                            List<double> result = Laba2.task5(X, Y);
                            Console.WriteLine("X: " + result[0] + "   Y: " + result[1]);

                        }
                        if (numberTask == 6)
                        {
                            double a;
                            double b;
                            double c;
                            Console.WriteLine("Введите a");
                            double.TryParse(Console.ReadLine(), out a);
                            Console.WriteLine("Введите b");
                            double.TryParse(Console.ReadLine(), out b);
                            Console.WriteLine("Введите c");
                            double.TryParse(Console.ReadLine(), out c);
                            List<double> result = Laba2.task6(a, b,c);
                            Console.WriteLine("a: " + result[0] + "   b: " + result[1] + "   c: " + result[2]);
                        }
                        if (numberTask == 7)
                        {
                            double X;
                            double Y;
                            double Z;
                            Console.WriteLine("Введите X");
                            double.TryParse(Console.ReadLine(), out X);
                            Console.WriteLine("Введите Y");
                            double.TryParse(Console.ReadLine(), out Y);
                            Console.WriteLine("Введите Z");
                            double.TryParse(Console.ReadLine(), out Z);
                            List<double> result = Laba2.task7(X, Y, Z);
                            string res = "";
                            foreach (double n in result)
                            {
                                res +=  n.ToString()+"; ";
                            }
                            Console.WriteLine(res);
                        }
                        if (numberTask == 8)
                        {
                            double X;
                            double Y;
                            double Z;
                            Console.WriteLine("Введите X");
                            double.TryParse(Console.ReadLine(), out X);
                            Console.WriteLine("Введите Y");
                            double.TryParse(Console.ReadLine(), out Y);
                            Console.WriteLine("Введите Z");
                            double.TryParse(Console.ReadLine(), out Z);
                            Console.WriteLine(" Max:  "+Laba2.task8(X, Y, Z));
                        }
                              
                        break;
                        
                }
                Console.WriteLine("Желаете продолжить?  y/n");
                if (Console.ReadLine() == "n" ) { rep = false; }
               
            }
        }
    }
}

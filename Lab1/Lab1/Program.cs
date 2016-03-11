using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;


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


                //словарb с задачами
                Dictionary<int, ILab1Executor> ExecutorsL1 = new Dictionary<int, ILab1Executor>();
                ExecutorsL1.Add(1, new L1task1());
                ExecutorsL1.Add(2, new L1task2());
                ExecutorsL1.Add(3, new L1task3());
                ExecutorsL1.Add(4, new L1task4());
                ExecutorsL1.Add(5, new L1task5());
                ExecutorsL1.Add(6, new L1task6());
                ExecutorsL1.Add(7, new L1task7());
                ExecutorsL1.Add(8, new L1task8());
                ExecutorsL1.Add(9, new L1task9());
                ExecutorsL1.Add(10, new L1task10());

                Dictionary<int, ILab2Executor> ExecutorsL2 = new Dictionary<int, ILab2Executor>();
                ExecutorsL2.Add(1, new L2task1());
                ExecutorsL2.Add(2, new L2task2());
                ExecutorsL2.Add(3, new L2task3());
                ExecutorsL2.Add(4, new L2task4());
                ExecutorsL2.Add(5, new L2task5());
                ExecutorsL2.Add(6, new L2task6());
                ExecutorsL2.Add(7, new L2task7());
                ExecutorsL2.Add(8, new L2task8());


                Dictionary<int, ILab3Executor> ExecutorsL3 = new Dictionary<int, ILab3Executor>();
                ExecutorsL3.Add(1, new L3task1());
                ExecutorsL3.Add(2, new L3task2());
                ExecutorsL3.Add(3, new L3task3());
                ExecutorsL3.Add(4, new L3task4());
                ExecutorsL3.Add(5, new L3task5());
                ExecutorsL3.Add(6, new L3task6());
                ExecutorsL3.Add(7, new L3task7());
                ExecutorsL3.Add(8, new L3task8());
                ExecutorsL3.Add(9, new L3task9());
                ExecutorsL3.Add(10, new L3task10());
                ExecutorsL3.Add(11, new L3task11());
                ExecutorsL3.Add(12, new L3task12());
                ExecutorsL3.Add(13, new L3task13());
                ExecutorsL3.Add(14, new L3task14());
                ExecutorsL3.Add(15, new L3task15());
                ExecutorsL3.Add(16, new L3task16());
                ExecutorsL3.Add(17, new L3task17());

                switch (numberLab)
                {
                        
                   
                    case 1:
                        lab1Calc Laba1 = new lab1Calc();
                        Console.WriteLine("Введите номер задачи 1-10");
                        Int32.TryParse(Console.ReadLine(), out numberTask);
                        
                        if (ExecutorsL1.ContainsKey(numberTask)) 
                        {
                            ILab1Executor Temp = ExecutorsL1[numberTask];
                            Temp.Execute(Laba1);
                        }
                       break;
                    case 2:
                        Lab2Calc Laba2 = new Lab2Calc();
                        Console.WriteLine("Введите номер задачи 1-8");
                        Int32.TryParse(Console.ReadLine(), out numberTask);
                        
                        if (ExecutorsL2.ContainsKey(numberTask)) 
                        {
                            ILab2Executor Temp = ExecutorsL2[numberTask];
                            Temp.Execute(Laba2);
                        }
                        break;
                    case 3:
                        Lab3Calc Laba3 = new Lab3Calc();
                        Console.WriteLine("Введите номер задачи 1-10");
                        Int32.TryParse(Console.ReadLine(), out numberTask);
                        
                        if (ExecutorsL3.ContainsKey(numberTask)) 
                        {
                            ILab3Executor Temp = ExecutorsL3[numberTask];
                            Temp.Execute(Laba3);
                        }
                        break;

                        
                }
                Console.WriteLine("Желаете продолжить?  y/n");
                if (Console.ReadLine() == "n" ) { rep = false; }
               
            }
        }
    }
}

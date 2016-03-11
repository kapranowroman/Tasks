using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace Lab1
{
    class L1task7 : ILab1Executor
    {
        public void Execute(lab1Calc Laba1)
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
    }
}

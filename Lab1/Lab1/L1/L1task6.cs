using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace Lab1
{
    class L1task6 : ILab1Executor
    {
        public void Execute(lab1Calc Laba1)
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
            Console.WriteLine("Расстояние между точками:  " + Laba1.task6(X1, Y1, X2, Y2));

        }
    }
}

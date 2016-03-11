using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class L2task6 : ILab2Executor
    {


        public void Execute(Lab2Calc Laba2)
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
            List<double> result = Laba2.task6(a, b, c);
            Console.WriteLine("a: " + result[0] + "   b: " + result[1] + "   c: " + result[2]);
        }
    }
}
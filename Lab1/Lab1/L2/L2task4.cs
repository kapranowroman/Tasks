using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class L2task4 : ILab2Executor
    {


        public void Execute(Lab2Calc Laba2)
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
            List<double> result = Laba2.task4(a, b, c, d);
            Console.WriteLine("a: " + result[0] + "    b: " + result[1] + "   c: " + result[2] + "  d:  " + result[3]);


        }
    }
}
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class L2task5 : ILab2Executor
    {


        public void Execute(Lab2Calc Laba2)
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
    }
}
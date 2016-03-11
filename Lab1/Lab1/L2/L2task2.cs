using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class L2task2 : ILab2Executor
    {


        public void Execute(Lab2Calc Laba2)
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
            Console.WriteLine("X: " + Laba2.task2(X, Y, Z)[0] + "    Y: " + Laba2.task2(X, Y, Z)[1] + "   Z: " + Laba2.task2(X, Y, Z)[2]);
                        
        }
    }
}
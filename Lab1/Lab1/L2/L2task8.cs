using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class L2task8 : ILab2Executor
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
            Console.WriteLine(" Max:  " + Laba2.task8(X, Y, Z));
        }
    }
}
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class L2task1 : ILab2Executor
    {


        public void Execute(Lab2Calc Laba2)
        {
            Console.WriteLine("Введите число А");
            double A;
            double.TryParse(Console.ReadLine(), out A);
            Console.WriteLine("Абсолютное значение:  " + Laba2.task1(A));  
        }
    }
}

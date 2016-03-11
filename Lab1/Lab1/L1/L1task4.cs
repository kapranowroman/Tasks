using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace Lab1
{
    class L1task4 : ILab1Executor
    {
        public void Execute(lab1Calc Laba1)
        {
            double X;
            Console.WriteLine("Введите число X");
            double.TryParse(Console.ReadLine(), out X);
            Console.WriteLine("Ответ:  " + Laba1.task4(X));
        }
    }
}

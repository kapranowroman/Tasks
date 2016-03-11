using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace Lab1
{
    class L1task8 : ILab1Executor
    {
        public void Execute(lab1Calc Laba1)
        {
            double a;
            Console.WriteLine("Введите длину грани куба");
            double.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Объем куба:  " + Laba1.task8_9(a)[0]);
        }
    }
}

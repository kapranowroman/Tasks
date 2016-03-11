using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace Lab1
{
    class L1task5: ILab1Executor
    {
        public void Execute(lab1Calc Laba1)
        {
            double R;
            Console.WriteLine("Введите значение угла в градусах");
            double.TryParse(Console.ReadLine(), out R);
            Console.WriteLine("Угол в радианах:  " + Laba1.task5(R));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;

namespace Lab1
{
    class L1task10 : ILab1Executor
    {
        public void Execute(lab1Calc Laba1)
        {
            int X1;
            int Y1;
            int H;
            int W;
            Console.WriteLine("Введите X1");
            int.TryParse(Console.ReadLine(), out X1);
            Console.WriteLine("Введите Y1");
            int.TryParse(Console.ReadLine(), out Y1);
            Console.WriteLine("Введите H");
            int.TryParse(Console.ReadLine(), out H);
            Console.WriteLine("Введите W");
            int.TryParse(Console.ReadLine(), out W);

            try
            {
                Console.WriteLine("Координаты нижнего правого угла:  " + Laba1.task10(X1, Y1, H, W)[0] + "; " + Laba1.task10(X1, Y1, H, W)[1]);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Одно из введенных значений не корректно");
            }
        }
    }
}

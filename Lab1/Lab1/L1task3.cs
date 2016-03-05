using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L1;

namespace Lab1
{
    class L1task3 : ILab1Executor
    {


        public void Execute(lab1Calc Laba1)
        {
            double A;
            double H;
            Console.WriteLine("Введите основание а");
            double.TryParse(Console.ReadLine(), out A);
            Console.WriteLine("Введите высоту h");
            double.TryParse(Console.ReadLine(), out H);

            try
            {
                Console.WriteLine("Площадь треугольника:  " + Laba1.task3(A, H));
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Одно из введенных значений не корректно");
            }

        }
    }
}

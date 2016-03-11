using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class L3task8 : ILab3Executor
    {

        public void Execute(Lab3Calc Laba3)
        {
            double A;
            double B;
            Console.WriteLine("Введите A");
            double.TryParse(Console.ReadLine(), out A);
            Console.WriteLine("Введите B");
            double.TryParse(Console.ReadLine(), out B);

            try
            {
                Console.WriteLine(Laba3.task8(A, B));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

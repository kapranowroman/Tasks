using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class L3task3 : ILab3Executor
    {
        public void Execute(Lab3Calc Laba3)
        {
            int A;
            char B;
            Console.WriteLine("Введите A");
            int.TryParse(Console.ReadLine(), out A);
            Console.WriteLine("Введите B");
            char.TryParse(Console.ReadLine(), out B);

            try
            {
                Console.WriteLine(Laba3.task3(A, B));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

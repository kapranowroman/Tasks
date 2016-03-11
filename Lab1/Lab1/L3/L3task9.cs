using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class L3task9 : ILab3Executor
    {

        public void Execute(Lab3Calc Laba3)
        {
            int A;
            int B;
            Console.WriteLine("Введите A");
            int.TryParse(Console.ReadLine(), out A);
            Console.WriteLine("Введите B");
            int.TryParse(Console.ReadLine(), out B);

            try
            {
                Console.WriteLine(Laba3.task9(A, B));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class L3task6 : ILab3Executor
    {

        public void Execute(Lab3Calc Laba3)
        {
            int B;
            Console.WriteLine("Введите B");
            int.TryParse(Console.ReadLine(), out B);

            try
            {
                Console.WriteLine(Laba3.task6(B));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class L3task16 : ILab3Executor
    {

        public void Execute(Lab3Calc Laba3)
        {
            char S1;
            char S2;
            int W;
            int H;
            Console.WriteLine("Введите символ S1");
            char.TryParse(Console.ReadLine(), out S1);
            Console.WriteLine("Введите символ S2");
            char.TryParse(Console.ReadLine(), out S2);
            Console.WriteLine("Введите W");
            int.TryParse(Console.ReadLine(), out W);
            Console.WriteLine("Введите H");
            int.TryParse(Console.ReadLine(), out H);

            try
            {
                Console.WriteLine(Laba3.task16(S1,S2, W, H));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

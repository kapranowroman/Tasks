using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class L3task13 : ILab3Executor
    {

        public void Execute(Lab3Calc Laba3)
        {
            char S;
            int W;
            int H;
            Console.WriteLine("Введите символ");
            char.TryParse(Console.ReadLine(), out S);
            Console.WriteLine("Введите W");
            int.TryParse(Console.ReadLine(), out W);
            Console.WriteLine("Введите H");
            int.TryParse(Console.ReadLine(), out H);

            try
            {
                Console.WriteLine(Laba3.task13(S,W,H));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class L3task14 : ILab3Executor
    {

        public void Execute(Lab3Calc Laba3)
        {
            char S;
            int H;
            Console.WriteLine("Введите символ");
            char.TryParse(Console.ReadLine(), out S);
            Console.WriteLine("Введите H");
            int.TryParse(Console.ReadLine(), out H);

            try
            {
                Console.WriteLine(Laba3.task14(S, H));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class L3task5 : ILab3Executor
    {
        
        public void Execute(Lab3Calc Laba3)
        {
            int A;
            Console.WriteLine("Введите A");
            int.TryParse(Console.ReadLine(), out A);
            
            try
            {
                Console.WriteLine(Laba3.task5(A));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

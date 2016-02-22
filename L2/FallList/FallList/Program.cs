using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallList
{
    class Program
    {
        static void Main(string[] args)
        {

            List<double> num = new List<double> { 1, 3, 5, 4, 6, 8, -2, 0, 4, -12, 2 };
            List<double> num2 = num.FindAll(n => n>=-3 && n<=5);

            Console.WriteLine("    adasd "+ num2);
            
            
            
            
            
            foreach (double n in num2)
            {
            Console.WriteLine(n);
            }
                Console.ReadKey();


        }
    }
}

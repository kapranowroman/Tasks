using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t4
{
    class Program
    {
        static void Main(string[] args)
        {
            bool t = true;
            while (t == true)
            {
                Console.WriteLine("Введите число X: ");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Truncate(a));
                Console.WriteLine("Для выхода введите: q");
                if (Console.ReadLine() == "q")
                {
                    t = false;
                }

               // Console.ReadKey();
            }
        }
    }
}

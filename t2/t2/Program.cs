using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace t2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            while (a == true)
            {
                Console.WriteLine("Введите радиус шара: ");
                double r = double.Parse(Console.ReadLine());
                if (r > 0)
                {
                    double v = Math.PI * 4 * Math.Pow(r, 3) / 3; ;
                    Console.WriteLine("Объем шара: " + v);
                    Console.WriteLine("Для продолжения введите: y");
                    if (Console.ReadLine() != "y")
                    {
                        a = false;
                    }
                }
                else
                {
                    Console.WriteLine("Ошибка");
                    Console.ReadKey();

                }
            }

        }
    }
}

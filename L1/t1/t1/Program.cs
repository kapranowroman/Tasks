using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            while (a == true)
            {
                Console.WriteLine("Введите радиус окружности: ");
                double r = double.Parse(Console.ReadLine());
                if (r > 0)
                {
                    double c = Math.PI * 2 * r;
                    Console.WriteLine("Длина окружности равна: " + c);
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

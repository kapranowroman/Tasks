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
            bool t = true;
            while (t == true)
            {
                Console.WriteLine("Введите величину основания: ");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите величину высоты: ");
                double h = double.Parse(Console.ReadLine());
                if (a > 0 && h > 0)
                {
                    double s = a * h / 2; ;
                    Console.WriteLine("Площадь треугольника: " + s);
                    Console.WriteLine("Хотите продолжить?   y/n ");
                    if (Console.ReadLine() == "n")
                    {
                        t = false;
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

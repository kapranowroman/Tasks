using proj;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandLineInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какую операцию хотите выполнить?");
            Console.WriteLine("1. Создать заказ");
            Console.WriteLine("2. Создать этап");
            Console.WriteLine("3. Начать работу над Этапом");
            Console.WriteLine("4");
            Console.WriteLine("5");

            int operation; 
            Int32.TryParse(Console.ReadLine(), out operation);

            if (operation == 1)
            {
                Console.WriteLine("Заказчик:");
                string Customer = Console.ReadLine();
                Console.WriteLine("Менеджер:");
                string Manager = Console.ReadLine();
                Order order = new Order(Manager, Customer);
                            }
            if (operation == 2)
            {
                Console.WriteLine(":");

            }
            if (operation == 3)
            {
            }
            if (operation == 4)
            {
            }
            if (operation == 5)
            {
            }


            


        }
    }
}

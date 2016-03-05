using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L1;

namespace Lab1
{
    class L1task1 :ILab1Executor
    {
           
        
        public void Execute(lab1Calc Laba1)
        {
            double R;
            Console.WriteLine("Введите значение радиуса R");
            double.TryParse(Console.ReadLine(), out R);

            try
            {
                Console.WriteLine("Длина окружности:  " + Laba1.task1(R));
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Введено не корректное значение радиуса");
            }
        }
    }
}

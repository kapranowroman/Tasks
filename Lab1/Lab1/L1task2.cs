﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using L1;

namespace Lab1
{
    class L1task2 : ILab1Executor
    {


        public void Execute(lab1Calc Laba1)
        {
            double R;
            Console.WriteLine("Введите значение радиуса R");
            double.TryParse(Console.ReadLine(), out R);
            try
            {

                Console.WriteLine("Объем шара:  " + Laba1.task2(R));
            }
            catch (ArgumentException)
            {

                Console.WriteLine("Введено не корректное значение радиуса");
            }

        }
    }
}

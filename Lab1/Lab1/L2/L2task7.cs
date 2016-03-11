using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class L2task7 : ILab2Executor
    {


        public void Execute(Lab2Calc Laba2)
        {
            double X;
            double Y;
            double Z;
            Console.WriteLine("Введите X");
            double.TryParse(Console.ReadLine(), out X);
            Console.WriteLine("Введите Y");
            double.TryParse(Console.ReadLine(), out Y);
            Console.WriteLine("Введите Z");
            double.TryParse(Console.ReadLine(), out Z);
            List<double> result = Laba2.task7(X, Y, Z);
            string res = "";
            foreach (double n in result)
            {
                res += n.ToString() + "; ";
            }
            Console.WriteLine(res);
        }
    }
}
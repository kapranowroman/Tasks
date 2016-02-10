using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class T4
    {
        public T4 (double a)
        {
            this.a = a;
        }

        public double a { private set; get; }
       
        


        public double Trunc(double a)
        {
            return Math.Truncate(a);
        }

        public override string ToString()
        {
            return "Введено число: " + a + "    Результат: " + Trunc(a);
        }
    }
}

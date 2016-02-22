using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2
{
    class T1
    {
        public T1 (double a, double A_test)
        {
            this.a = a;
            this.A_test = A_test;
        }

        public double a { private set; get; }
        public double A_test { private set; get; }
       
        


        public double ABS(double a)
        {
            return Math.Abs(a);
        }

        public override string ToString()
        {
            return "Введено число: " + a + "    Результат: " + ABS(a)+ " Ожидаемое значение: " + A_test;
        }
    }
}

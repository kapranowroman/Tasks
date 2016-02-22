using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2
{
    class T4
    {
        public double a { private set; get; }
        public double b { private set; get; }
        public double c { private set; get; }
        public double d { private set; get; }
        public string test { private set; get; }

        public T4(double a, double b, double c, double d, string test)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.test = test;
        }
        public override string ToString()
        {
            if (a > b && b > c && c > d)
            {
                return Math.Pow(a, 2) + "  " + Math.Pow(b, 2) + "  " + Math.Pow(c, 2) + "  " + Math.Pow(d, 2) + "       Ожидаемый ответ: " + test;
            }
            else 
            {
                return a + "  " + b + "  " + c + "  " + d + "    Ожидаемый ответ: " + test;
            }
        
        }
    }
}

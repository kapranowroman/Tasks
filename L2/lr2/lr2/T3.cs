using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2
{
    class T3
    {
        public double a { private set; get; }
        public double b { private set; get; }
        public double c { private set; get; }
        public string test { private set; get; }

        public T3(double a, double b, double c, string test)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.test = test;
        }
        public override string ToString()
        {
            if (a < b && b < c)
            {
                return "Выполняется" + "    Ожидаемый ответ: " + test;
            }
            else 
            {
                return "Не выполняется" + "    Ожидаемый ответ: " + test;
            }
        
        }

    }
}

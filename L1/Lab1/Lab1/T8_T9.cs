using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class T8_T9
    {
        public T8_T9(double a, string V_test, string S_test)
        {
            this.a = a;
            this.V_test = V_test;
            this.S_test = S_test;
        }

        public double a { private set; get; }
        public string V_test { private set; get; }
        public string S_test { private set; get; }

        public double Volume(double a)
        {
            return Math.Pow(a, 3);
        }
        public double area(double a)
        {
            return 6 * Math.Pow(a, 2);
        }

        public override string ToString()
        {
            if (a <= 0) 
            {
                return "Сторона куба: " + a + "    Объем: " + "error" + "  Площадь: " + "error" + "  V ожидаемое: " + V_test + "  S ожидаемое: " + S_test;
            }
            return "Сторона куба: " + a + "    Объем: " + Volume(a) + "  Площадь: " + area(a) + "  V ожидаемое: " + V_test + "  S ожидаемое: " + S_test;
        }

    }
}

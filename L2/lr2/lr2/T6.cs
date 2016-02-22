using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2
{
    class T6
    {
        public double A { private set; get; }
        public double B { private set; get; }
        public double C { private set; get; }
        public string test { private set; get; }

        public T6(double A, double B, double C,  string test)
        {
            this.A = A;
            this.B = B;
            this.C = C;
            this.test = test;
        }
        public override string ToString()
        {
            if (A >= B && B >= C)
            {
                return A * 2 + "  " + B * 2 + "  " + C * 2 + "       Контроль:  " + test;
            }
            else
            {
                return Math.Abs(A) + "  " + Math.Abs(B) + "  " + Math.Abs(C) + "       Контроль:  " + test;
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MyComparer : IComparer
    {
        private const double Tolerance = 0.001;

        public int Compare(object x, object y)
        {
            double x1 = (double)x;
            double y1 = (double)y;

            if (Math.Abs(x1 - y1) <= Tolerance)
                return 0;

            return x1 > y1 ? 1 : -1;
        }
    }
}

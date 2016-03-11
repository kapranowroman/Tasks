using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class MyComparer2 : IComparer<double>
    {
        public  const double Tolerance = 0.001;

        public int Compare(double x, double y)
        {

            if (Math.Abs(x - y) <= Tolerance)
                return 0;

            return x > y ? 1 : -1;
        }
    }
}

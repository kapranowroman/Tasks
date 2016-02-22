using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    public class lab1
    {
        public double task2(double R)
        {
            if (R <= 0)
            {
                throw new ArgumentException("R > 0");
            }
            double res = 4 * Math.PI * Math.Pow(R, 3) / 3;
            return res;
        }

    }
}
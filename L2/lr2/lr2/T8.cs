using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2
{
    class T8
    {
        public double X { private set; get; }
        public double Y { private set; get; }
        public double Z { private set; get; }
        public string test { private set; get; }

        public T8(double X, double Y, double Z, string test)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
            this.test = test;
            
        }

        public double number(double X, double Y, double Z)
        {
            List<double> num = new List<double> { X, Y, Z };
            double result = num.Max();
            return result;

        }
        public override string ToString()
        {
            return "Max value = " + number(X, Y, Z) + "      Test: " + test; 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2
{
    class T7
    {
        public double X { private set; get; }
        public double Y { private set; get; }
        public double Z { private set; get; }
        public string test { private set; get; }

        public T7(double X, double Y, double Z, string test)
        {
            this.X = X;
            this.Y = Y;
            this.Z = Z;
            this.test = test;
        }


        public List<double> number(double X, double Y, double Z)
        {
            List<double> num = new List<double> { X, Y, Z };
            List<double> result = num.FindAll(n => n >= -3 && n <= 5);
            return result;

        }
        public override string ToString()
        {
            String retVal = String.Empty;
            foreach (double T in number(X, Y, Z))
            {
                if (String.IsNullOrEmpty(retVal))
                    retVal += T.ToString();
                else
                    retVal += String.Format(", {0}", T);
            }
            return retVal + "      Test: " + test;

        }
    }
}

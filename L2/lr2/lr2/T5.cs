using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2
{
    class T5
    {
        public double X { private set; get; }
        public double Y { private set; get; }
        public string test { private set; get; }

        public T5(double X, double Y,  string test)
        {
            this.X = X;
            this.Y = Y;
            
            this.test = test;
        }
        public override string ToString()
        {
            if (X < 0  || Y <0)
            {
                return Math.Abs(X) + "  " + Math.Abs(Y) + "       Ожидаемый ответ: " + test;
            }
            else 
            {
                return X + "  " + Y + "  "  + "    Ожидаемый ответ: " + test;
            }
        
        }
    }
}

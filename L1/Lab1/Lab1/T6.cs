using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class T6
    {
        

        public int X1 { private set; get; }
        public int Y1 { private set; get; }
        public int X2 { private set; get; }
        public int Y2 { private set; get; }
        public double dist_test { private set; get; }

        public T6(int X1, int Y1, int X2, int Y2, double dist_test)
        {
            this.X1 = X1;
            this.Y1 = Y1;
            this.X2 = X2;
            this.Y2 = Y2;
            this.dist_test = dist_test;
        }

        public double Distance(int X1, int Y1, int X2, int Y2)
        {
            return Math.Sqrt(Math.Pow(X2 - X1,2)+Math.Pow(Y2 - Y1,2));
        }

        public override string ToString()
        {
            return "X1: " + X1 + " Y1: " + Y1 + " X2: " + X2 + " Y2: " + Y2 + "    Расстояние: " + Distance(X1, Y1, X2, Y2) + "  Контроль: " + dist_test;
        }
    }
}

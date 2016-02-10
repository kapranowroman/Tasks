using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class T10
    {
        public int X1 { private set; get; }
        public int Y1 { private set; get; }
        public int H { private set; get; }
        public int W { private set; get; }
        public string X_test { private set; get; }
        public string Y_test { private set; get; }

        public T10(int X1, int Y1, int H, int W, string X_test, string Y_test)
        {
            this.X1 = X1;
            this.Y1 = Y1;
            this.H = H;
            this.W = W;
            this.X_test = X_test;
            this.Y_test = Y_test;
        }

        public int CoordinateX(int X1, int W)
        {
            if (X1 >= 0 && W > 0)
            {
                return X1 + W;
            }
            else 
            {
                return 0;
            }
        }
        public int CoordinateY(int Y1, int H)
        {
            
            return Y1 + H;
           
        }

        public override string ToString()
        {
            if ((Y1 < 0 || H <=0 || X1<0 || W<=0))
            {
                return "X1: " + X1 + "Y1: " + Y1 +" H: "+H+"  W: "+W+"   X:  " + " Error " + " Y: " + " Error  " + " Контроль: " + X_test + "   " + Y_test;
               
            }
            else
            {
                return "X1: " + X1 + " Y1: " + Y1 + " H: " + H + "  W: " + W + "   X:  " + CoordinateY(X1, W) + " Y: " + CoordinateY(Y1, H) + "  Контроль: " + X_test + "   " + Y_test;
            }
            
        }
    }
}

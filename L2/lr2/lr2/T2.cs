using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr2
{
    class T2
    {
        public T2(double x, double y, double z, double x_test, double y_test, double z_test)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.x_test = x_test;
            this.y_test = y_test;
            this.z_test = z_test;
        }

        public double x { private set; get; }
        public double y { private set; get; }
        public double z { private set; get; }
        public double x_test { private set; get; }
        public double y_test { private set; get; }
        public double z_test { private set; get; }

        public override string ToString() 
        {
            if (x>=0){x=Math.Pow(x,2);}
            if (y>=0){y=Math.Pow(y,2);}
            if (z>=0){z=Math.Pow(z,2);}
            return "x: " + x + " y: " + y + " z: " + z + "     Контроль  x: " + x_test + " y: " + y_test + " z: " + z_test; 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class T5
    {
        public T5 (double grad)
        {
            this.grad = grad;
        }

        public double grad { private set; get; }
       
        


        public double Convert (double grad)
        {
            if (grad < 0) 
            { 
                return (360 + grad) * Math.PI / 180; 
            }
            else if (grad >= 360)
            {
                return (grad - grad * (Math.Truncate(grad / 360))) * Math.PI / 180;
            }
            else 
            {
                return grad * Math.PI / 180; 
            }
        }

        public override string ToString()
        {
            return "Введено : " + grad + "    Результат: " + Convert(grad);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class T7
    {
        public double V1 { private set; get; }
        public double T1 { private set; get; }
        public double V2 { private set; get; }
        public double T2 { private set; get; }
        public string V_test { private set; get; }
        public string T_test { private set; get; }

        public T7(double V1, double T1, double V2, double T2, string V_test, string T_test)
        {
            this.V1 = V1;
            this.T1 = T1;
            this.V2 = V2;
            this.T2 = T2;
            this.V_test = V_test;
            this.T_test = T_test;
        }

        public double Volume(double V1, double V2)
        {
            return V1 + V2;
        }
        public double Temperature(double V1, double T1, double V2, double T2)
        {
            return (T1 * V1 + T2 * V2) / Volume(V1, V2);
        }

        public override string ToString()
        {
            if (V1 < 0 || V2 < 0)
            {
                return "V1: " + V1 + " T1: " + T1 + " V2: " + V2 + " T2: " + T2 + "    Объем: " + "Ошибка" + "  Температура: " + "Ошибка" + " контрольные значения: V= " + V_test + " T= " + T_test;
            }
            else
            {
                return "V1: " + V1 + " T1: " + T1 + " V2: " + V2 + " T2: " + T2 + "    Объем: " + Volume(V1, V2) + "  Температура: " + Temperature(V1, T1, V2, T2) + " контрольные значения: V= " + V_test + " T= " + T_test;
            }
        }
    }
}

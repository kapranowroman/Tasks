using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class lab1Calc
    {
        //Задача №1 Вычислить длину окружности по формуле C=2πR
        public double task1(double R)
        {
            if (R <= 0)
            {
                throw new ArgumentException("R > 0");
            }
            double res = 2 * Math.PI * R;
            return res;
        }

        //Задача №2
        public double task2(double R)
        {
            if (R <= 0)
            {
                throw new ArgumentException("R > 0");
            }
            double res = 4 * Math.PI * Math.Pow(R, 3) / 3;
            return res;
        }
        //Задача №3 Вычислить площадь прямоугольного треугольника по формуле S=ah/2, где a - основание, h - высота.
        public double task3(double a, double h)
        {
            if (a <= 0 || h<=0)
            {
                throw new ArgumentException("a > 0 & h > 0");
            }
            double res = a*h/2;
            return res;
        }

        //Задача №4. Дано действительное число X. Нужно отбросить его дробную часть.

        public double task4(double a)
        {
            return Math.Truncate(a);
        }

        //Задача №5. Перевести угол из градусов в радианы по формуле: B=A*π/180, где A - угол в градусах, B - угол в радианах.

        public double task5(double grad)
        {
            if (grad < 0)
            {
                return (360 + grad) * Math.PI / 180;
            }
            else if (grad >= 360)
            {
                return (grad - 360 * (Math.Truncate(grad / 360))) * Math.PI / 180;
            }
            else
            {
                return grad * Math.PI / 180;
            }
        }

        //Задача №6. Вычислить расстояние между двумя точками с координатами (X1, Y1) и (X2, Y2) по формуле √(X2 - X1)2 + (Y2 - Y1)2

        public double task6(int X1, int Y1, int X2, int Y2)
        {
            return Math.Sqrt(Math.Pow(X2 - X1, 2) + Math.Pow(Y2 - Y1, 2));
        }

        //Задача №7

        public List<double> task7(double V1, double T1, double V2, double T2)
        {
            if (V1 > 0 && V2 > 0)
            {
                List<double> result = new List<double> { V1 + V2, (T1 * V1 + T2 * V2) / (V1 + V2) };
                return result;
            }
            else
            {
                throw new ArgumentException("Объем должен быть > 0");
            }
        }


        //Задача №8 + 9. Дана длина ребра куба. Найти объем куба по формуле V=a3 и площадь его боковой поверхности по формуле S=6a2.

        public List<double> task8_9(double a)
        {
            if (a > 0)
            {
                List<double> result = new List<double> { Math.Pow(a, 3), 6 * Math.Pow(a, 2) };
                return result;
            }
            else
            {
                throw new ArgumentException("Длина ребра куба не может быть < 0");
            }
        }
        
        //Задача №10
        public List<int> task10(int X1, int Y1, int H, int W)
        {
            if (X1 >= 0 && Y1 >=0 && H > 0 && W > 0)
            {
                List<int> result = new List<int> { X1 + W, Y1 + H };
                return result;
               
            }
            else
            {
                throw new ArgumentException("Не корректно одно из значений");
            }
        }
        

    }
}
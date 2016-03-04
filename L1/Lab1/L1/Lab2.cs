using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L1
{
    public class Lab2
    {
        //Задача №1 Дано число A. Вывести его абсолютное значение.
        public double task1(double A)
        {
            double res = Math.Abs(A);;
            return res;
        }
        
        //Задача №2 Даны три действительных числа. Если число неотрицательно - вывести его квадрат. Иначе - само число.

        public List<double> task2(double x, double y, double z)
        {
            if (x >= 0) { x = Math.Pow(x, 2); }
            if (y >= 0) { y = Math.Pow(y, 2); }
            if (z >= 0) { z = Math.Pow(z, 2); }
            List<double> result = new List<double> { x, y, z };
            return result;
        }

        //Задача №3. Даны действительные числа a, b, c. Проверить, выполняются ли неравенства a<b<c.

        public bool task3(double a, double b, double c)
        {
            if (a < b && b < c)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Задача №4. 
        //Даны четыре действительных числа a, b, c, d. 
        //Если a>b>c>d, то вывести квадраты этих чисел. 
        //Если условие не выполняется, вывести значения без изменений.

        public List<double> task4(double a, double b, double c, double d)
        {

            if (a > b && b > c && c > d)
            {
                List<double> result = new List<double> { Math.Pow(a, 2), Math.Pow(b, 2), Math.Pow(c, 2), Math.Pow(d, 2) };
                return result;
            }
            else
            {
                List<double> result = new List<double> { a, b, c, d };
                return result;
            }
        }
        //Задача №5.
        //Даны действительные числа x, y. 
        //Если одно из этих чисел отрицательно, то вывести модули обоих чисел.

        public List<double> task5(double X, double Y)
        {
            if (X < 0 || Y < 0)
            {
                List<double> result = new List<double> { Math.Abs(X), Math.Abs(Y) };
                return result;
            }
            else
            {
                List<double> result = new List<double> {X, Y};
                return result;
            }
        }
        //Задача №6.
        //Даны действительные числа a, b, c. Если a>=b>=c, вывести их удвоенные значения. 
        //В ином случае - вывести их абсолютные значения.
        public List<double> task6(double A, double B, double C)
        {
            if (A >= B && B >= C)
            {
                return new List<double> {A*2, B*2, C*2};
            }
            else
            {
                return new List<double> { Math.Abs(A), Math.Abs(B), Math.Abs(C) };
            }
        }
        //Задача №7.
        //Даны три действительных числа. Вывести только те числа, которые принадлежат интервалу (-3,5).
        public List<double> task7(double X, double Y, double Z)
        {
            List<double> num = new List<double> { X, Y, Z };
            List<double> result = num.FindAll(n => n >= -3 && n <= 5);
            return result;
        }
        //Задача №8.
        //Даны действительные числа x, y, z. Вывести на экран значение наибольшего из них.
        public double task8(double X, double Y, double Z)
        {
            List<double> num = new List<double> { X, Y, Z };
            double result = num.Max();
            return result;

        }

    }
}

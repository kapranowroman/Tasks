using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Lab3Calc
    {
        //Задача №1 
        public string task1(int A, int B)
        {
            string result = "";
            if (A > B)
            {
                throw new ArgumentException("Не выполнено условие B>=A");
            }
            for (int i = A; i <= B; i++)
            {
                result += i + "\n";
            }
            return result;
        }
        //Задача №2 
        public string task2(int A, int B)
        {
            string result = "";
            if (A > B)
            {
                throw new ArgumentException("Не выполнено условие B>=A");
            }
            for (int i = B; i >= A; i--)
            {
                result += i + " ";
            }
            return result;
        }
        //Задача №3 
        public string task3(int A, char B)
        {
            string result = "\"";
            if (A < 0)
            {
                throw new ArgumentException("А должно быть больше 0");
            }
            for (int i = 0; i < A; i++)
            {
                result += B;
            }
            result += "\"";
            return result;
        }
        //Задача №4 
        public int task4()
        {
            int result = 0;
            for (int i = 100; i < 500; i++)
            {
                result += i;
            }
            return result;
        }
        //Задача №5 
        public int task5(int A)
        {
            int result = 0;
            if (A < -100 || A > 500)
            {
                throw new ArgumentException("А не соответствует условию: -100<=A<=500");
            }
            for (int i = A; i <= 500; i++)
            {
                result += i;
            }
            return result;
        }
        //Задача №6 
        public int task6(int B)
        {
            int result = 0;
            if (B < -10)
            {
                throw new ArgumentException("B не соответствует условию: B>-10");
            }
            for (int i = -10; i <= B; i++)
            {
                result += i;
            }
            return result;
        }
        //Задача №7 
        public int task7(int A, int B)
        {
            int result = 0;
            if (A > B)
            {
                throw new ArgumentException("Не Выполняется условие: A<=B");
            }
            for (int i = A; i <= B; i++)
            {
                result += i;
            }
            return result;
        }
        //Задача №8 
        public int task8(double A, double B)
        {

            if (A > B)
            {
                throw new ArgumentException("Не Выполняется условие: A<=B");
            }

            int a = (int)Math.Truncate(A);
            int b = (int)Math.Truncate(B);
            int result = 1;

            if (a == b) { result = a * b; }
            else
            {
                if (a < A)
                {
                    for (int i = a + 1; i <= b; i++)
                    {
                        result *= i;
                    }
                }
                else
                {
                    for (int i = a; i <= b; i++)
                    {
                        result *= i;
                    }
                }
            }
            return result;
        }
        //Задача №9 
        public int task9(int A, int B)
        {
            int result = 0;
            if (A > B)
            {
                throw new ArgumentException("Не Выполняется условие: A<=B");
            }
            for (int i = A; i <= B; i++)
            {
                if (i % 7 == 0)
                {
                    result += i;
                }
            }
            return result;
        }
        //Задача №10
        public int task10()
        {
            int result = 0;

            for (int i = 100; i <= 1000; i++)
            {
                if (i % 13 == 0)
                {
                    result += 1;
                }
            }
            return result;
        }
        //Задача №11
        public int task11()
        {
            int result = 0;

            for (int i = 20; i <= 40; i++)
            {

                result += (int)Math.Pow(i, 3);

            }
            return result;
        }
        //Задача №12 
        public int task12(int A, int B)
        {
            int result = 0;
            if (A > B)
            {
                throw new ArgumentException("Не Выполняется условие: A<=B");
            }
            for (int i = A; i <= B; i++)
            {

                result += (int)Math.Pow(i, 2);

            }
            return result;
        }
        //Задача №13 
        public string task13(char S, int W, int H)
        {
            string result = "";
            if (W < 0 || H < 0)
            {
                throw new ArgumentException("Не Выполняется условие: A<=B");
            }
            for (int i = 0; i < H; i++)
            {
                if (result != "")
                {
                    result += "\n";
                }
                for (int j = 0; j < W; j++)
                {
                    result += S;
                }

            }
            return result;
        }
        //Задача №14 
        public string task14(char S, int H)
        {
            string result = "";
            if (H < 0)
            {
                throw new ArgumentException("Введенное значение не может быть меньше 0");
            }
            for (int i = 1; i <= H; i++)
            {
                if (result != "")
                {
                    result += "\n";
                }
                //string res = new String(S,i);
                result += new String(S, i);
            }
            return result;
        }
        //Задача №15 
        public string task15(int A, int B)
        {
            string result = "";
            if (A>B)
            {
                throw new ArgumentException("Не Выполняется условие: A<=B");
            }
            int counter = 0;
            for (int i = A; i <= B; i++)
            {
                if (i%2!=0)
                {
                    
                    if (result != "")
                    {
                        result += "\n";
                    }
                
                        result += new String(' ', counter)+ i;
                        counter += 1;
                }

            }
            return result;
        }
        //Задача №16 
        public string task16( char S1, char S2, int W, int H)
        {
            string result = "";
            if (W<0 || H<0)
            {
                throw new ArgumentException("W и H не могут быть отрицательными");
            }
            for (int i = 1; i <= H; i++)
            {
                if (i % 2 != 0)
                {

                    if (result != "")
                    {
                        result += "\n";
                    }

                    result += new String(S1, W);

                }
                else
                {
                    if (result != "")
                    {
                        result += "\n";
                    }
                    result += new String(S2, W);
                }

            }
            return result;
        }
        //Задача №17 
        public string task17(int A, int B)
        {
            string result ="";
            if (A > B)
            {
                throw new ArgumentException("Не Выполняется условие: A<=B");
            }
            for (int i = A; i <= B; i++)
            {
                if (i % 2 != 0)
                {
                     if (result != "")
                    {
                        result += ",";
                    }
                     result += i;
                }
            }
            return result;
        }
    }

}

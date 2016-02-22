using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            double X = 2;
            double Y = 5;
            double Z = 8;
            List<double> num = new List<double> { X, Y, Z };
            List<double> num2 = new List<double>();
            //List<double> num3=new List<double>();
            //List<double> num3 = num.FindAll(i > -3 && i < 5);

            foreach (double i in num)
            {
                if (i >= -3 && i <= 5)
                {
                    num2.Add(i);
                }
            }
            num2.Add(15);

            foreach (double s in num2)
                Console.WriteLine(s);

            string otvet = num.ToString();
            Console.WriteLine(otvet);





            // Find all computer books.
            List<Book> results = Books.FindAll(FindComputer);
            if (results.Count != 0)
            {
                DisplayResults(results, "All computer:");
            }
            else
            {
                Console.WriteLine("\nNo books found.");
            }

            Book Books = new Book() { };
            // Find all books under $10.00.
            results = Books.FindAll(
            delegate(Book bk)
            {
                return bk.Price < 10.00;
            }
            );
            if (results.Count != 0)
            {
                Console.WriteLine(results + "Books under $10:");
            }
            else
            {
                Console.WriteLine("\nNo books found.");
            }
            Console.ReadKey();
        }


        public class Book
        {
            public string ID { get; set; }
            
        }


    }
}

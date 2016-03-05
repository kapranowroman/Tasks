using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileRead
{
    class Program
    {
        static void Main(string[] args)
        {   string path = "C:\\Temp\\5 ОСАЛП\\task6test1.txt";
        if (File.Exists(path))
        {
            StreamReader reader = new StreamReader(path);
            
            
            
            
           
           string res = reader.ReadLine();
           
           string fragment =  res.Substring(0, res.IndexOf(','));
            //int res2 = reader.Read();
            //int res3 = reader.Read();
            //int res4 = reader.Read();
            //String str = reader.ReadLine();
            
            
            
            
            
            Console.WriteLine(fragment);
            Console.ReadKey();
            reader.Close();
        }
        }
    }
}

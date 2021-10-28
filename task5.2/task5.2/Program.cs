using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5._2
{
    class Program
    {
        static void Main(string[] args)
        {
          

            string str2 = "клавиатура";
            str2 = str2.Replace("клавиату", "тиа");
            Console.WriteLine(str2);
            string str = "";
            str = "клавиатура";
            Console.WriteLine(str);
            string result1 = str.Substring(8, 1) + str.Substring(7, 1) + str.Substring(0, 1) + str.Substring(2, 1);
            Console.WriteLine(result1);
            Console.ReadKey();
        }
    }
}

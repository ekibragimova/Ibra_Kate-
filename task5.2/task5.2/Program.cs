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
            string result = str2.Substring(6, 1) + str2.Substring(4, 2) + str2.Substring(8, 2);
            Console.WriteLine(result);

            string str = "клавиатура";
            string result1 = str.Substring(8, 1) + str.Substring(7, 1) + str.Substring(0, 1) + str.Substring(2, 1);
            Console.WriteLine(result1);
            Console.ReadKey();
        }
    }
}

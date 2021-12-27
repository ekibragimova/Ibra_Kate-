using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 1;
            double a = double.Parse(Console.ReadLine());
            while ( a != 0)
            {
                result = result * a;
                a = double.Parse(Console.ReadLine());
            }
            result = Math.Sqrt(result);
            Console.WriteLine(result);
        }
    }
}

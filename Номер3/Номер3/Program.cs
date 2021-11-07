using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Номер3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter x = ");
            var x = double.Parse(Console.ReadLine());
            Console.WriteLine(GoToCount(x));
            Console.ReadKey();
        }
        static double GoToCount(double x)
        {
            return 1 + Math.Sqrt((x * x - 1) / (x * x + 1));
        }
    }
}

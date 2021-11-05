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
            Console.WriteLine("enterx = ");
            Console.WriteLine(GoToCount());
            Console.ReadKey();
        }
        static double GoToCount()
        {
            double y;
            var x = double.Parse(Console.ReadLine());
            return y = 1 + Math.Sqrt((x * x - 1) / (x * x + 1));
 
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yjvth4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Round (GoToG(2, 3) + GoToG(3,5) * GoToG(5, 7),3));
            Console.ReadKey();
        }
        static double GoToG(double n1, double n2)
        {
            return Math.Pow(Math.E, -Math.Sqrt(n1 + n2 * n2));
        }
    }
}

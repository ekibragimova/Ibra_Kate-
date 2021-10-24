using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задание4
{
    class Program
    {
        static void Main(string[] args)
        {
            double g;
            Console.WriteLine(Math.Round(value: g = Conclusion, digits: 3));
            Console.ReadKey();





        }
        static double Conclusion
        {
            get
            {
                double  g;
                double e  = Math.E;
                double q = -Math.Sqrt((2 + 3 * 3));
                double x = Math.Pow(e, q);
                double w = -Math.Sqrt((3 + 5 * 5));
                double y = Math.Pow(e, w);
                double z = -Math.Sqrt((5 + 7 * 7));
                double h = Math.Pow(e, z);
                return g = x + y * h;
                
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату x= ");
            double x;
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите координату y= ");
            double y;
            y = double.Parse(Console.ReadLine());
            Console.WriteLine(Coordinates(x, y));
            Console.ReadKey();
        }
        static bool Coordinates(double ox, double oy)
        {
            if ((ox > 2) && (oy > 0) && (ox > 1) && (ox < -1))
                return true;
            else
                return false;
         
             
        }

       

    }
}

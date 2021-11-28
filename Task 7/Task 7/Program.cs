using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter coordinate x = ");
            var x = int.Parse(Console.ReadLine());
            Console.WriteLine($"полученное значение функции:" + Coordinate(x));
            Console.ReadLine();
        }
        static double Coordinate (int x)
        {
            if (x < -1)
                return (x = 1);
           else if (x > 1)
                return (x = -1);
            else 
                    return (-x);
        }
    }
}

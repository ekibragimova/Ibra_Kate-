using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_8._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter numbers");
            int n = int.Parse(Console.ReadLine());
            int a;
            int aMin = 10;

            while (n > 0)
            {
                a = n % 10;
                n = n / 10;
                if ( a< aMin) { aMin = a; }
            }
            Console.WriteLine(aMin);
        }
    }
}

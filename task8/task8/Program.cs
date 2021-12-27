using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8
{
    class Program
    {
        static void Main(string[] args)
        {
            int Result = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                Result = Result + (n + i) * (n + i);
            }
            Console.WriteLine(Result);
            Console.ReadKey();
        }

    }
}

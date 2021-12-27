using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = 0;
            Console.WriteLine("enter a quantity of subjects: ");
            int K = int.Parse(Console.ReadLine());
            for (int i = 1; i <= K; i++)
            {
                Console.WriteLine("Enter marks: ");
                r += (double.Parse(Console.ReadLine()));
            }
            Console.WriteLine(r / K);
            Console.ReadKey();
        }
    }
}

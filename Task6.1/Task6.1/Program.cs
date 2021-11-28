using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число = ");
            int x;
            x = int.Parse(Console.ReadLine());
            Console.WriteLine(multipleornot(x));
            Console.ReadKey();
        }
        static bool multipleornot(int number)
        {
            return (number % 5 == 0) || (number % 7 == 0);
                
        }
    }
}

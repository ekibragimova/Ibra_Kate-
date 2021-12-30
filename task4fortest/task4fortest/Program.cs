using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4fortest
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            int mistake = 0;
            while (mistake != 1)
            {
                for (int p = 1; p <= number; p++)
                {
                    if (TheSpherOfEratosphen(p) == true)
                        number += 2;
                    for (var m = 1; m < number; m++)
                    {
                        if (number == p + 2 * m * m)
                            break;
                        else;
                        Console.WriteLine(number);
                        mistake = 1;
                    }
                }
            }
            static bool TheSpherOfEratosphen(int a)
            {
                int c = 1;
                for (int i = 2; i <= Math.Sqrt(a); i++)
                {
                    if (a % i == 0)
                    {
                        c = 0;
                        break;
                    }
                }
                return (c == 1);

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter 'n'");
                int n = int.Parse(Console.ReadLine());
                int[] arr = new int[n];
                double pi = Math.PI;
                for (int i = 0; i < n; i++)
                {
                    arr[i] = (int)pi;
                    pi = (pi - (int)pi) * 10;
                }

                PrintArr(arr);
                NewArr(ref arr);
                PrintArr(arr);
                Console.WriteLine("Enter 'm'");
                int m = int.Parse(Console.ReadLine());
                Console.WriteLine(QtyOfM(arr, m));
                PrintArr(ZeroOrOne(arr));
                Console.ReadKey();
            }
            static void PrintArr(int[] arr)
            {
                int c = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    c++;
                    if (c > 10) { Console.WriteLine(); c = 0; }
                    Console.Write(arr[i] + " ");
                }
                Console.WriteLine();
            }
            static void NewArr(ref int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = 9 - arr[i];
                }

            }
            static int QtyOfM(int[] arr, int m)
            {
                int qty = 0;
                foreach (int i in arr)
                {
                    if (i == m) { qty++; }
                }
                return (qty);
            }
            static int[] ZeroOrOne(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = arr[i] % 2;
                }
                return (arr);
            } 
        }
    }
}

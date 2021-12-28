using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task10
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк массива в пределах от 5 до 20: ");
            var rowNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество столбцов массива в пределах от 5 до 20: ");
            var columnNumber = int.Parse(Console.ReadLine());

            var matrix = new int[rowNumber, columnNumber];
            FillRandom(matrix);
            PrintMatrix(matrix);

            var average = GetAverageByRow(matrix);
            for (var i = 0; i < average.Length; i++)
                Console.WriteLine($"Строка:{i,2} Среднее: {average[i]}");

            Console.ReadKey();
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                for (var j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($"{matrix[i, j],3} ");
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        static void FillRandom(int[,] matrix)
        {

            for (var i = 0; i < matrix.GetLength(0); i++)
                for (var j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = rnd.Next(0, 100);

        }

        static double[] GetAverageByRow(int[,] matrix)
        {
            var result = new double[matrix.GetLength(0)];

            for (var i = 0; i < matrix.GetLength(0); i++)
            {
                var srednee = 0.0;

                for (var j = 0; j < matrix.GetLength(1); j++)
                    srednee += matrix[i, j];

                result[i] = srednee / matrix.GetLength(1);
            }

            return result;

        }
    }
}

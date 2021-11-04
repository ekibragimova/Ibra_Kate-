using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Диаметр внешнего кольца: ");
            double D = Convert.ToDouble(Console.ReadLine());
            Console.Write("Диаметр внутреннего кольца: ");
            double d = Convert.ToDouble(Console.ReadLine());
            double PI = Math.PI;

            Console.WriteLine("Площадь кольца = " + (PI / 4 * (D * D - d * d)));
            Console.Read();
        }
    }
}

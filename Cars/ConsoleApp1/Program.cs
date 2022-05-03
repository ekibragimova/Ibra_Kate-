using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            UsedCar s = new UsedCar("Lada", "dddsss444", CarBodyType.Sedan, "23.03.2020", "Anna", 3000000, 2017, 100000, "хорошее");
            Console.WriteLine(s.GetInfo()[1]);
        }
    }
}

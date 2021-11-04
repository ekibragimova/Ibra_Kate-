using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Стихотворение
{
    class Program
    {
        public static object По { get; private set; }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Школьный сентябрь");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Сентябрь. Прозвенел звонок,");
            Console.WriteLine("Малышка в первый класс шагает.");
            Console.WriteLine("И жёлтых листиков клубок,");
            Console.WriteLine("По небу ветерок гоняет.");
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey(); 
        }
    }
}

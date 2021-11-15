using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите текст на английском: ");


            string text = Console.ReadLine().ToLower();

            Console.WriteLine(TranslateOnLeet(text));

            Console.ReadKey();
        }
        static string TranslateOnLeet(string x)
        {

            x = x.Replace("a", "4");
            x = x.Replace("e", "3");
            x = x.Replace("i", "!");
            x = x.Replace("q", "9");
            x = x.Replace("b", "6");
            x = x.Replace("f", "|=");
            x = x.Replace("j", ")");
            x = x.Replace("r", "|2");
            x = x.Replace("z", "2");
            x = x.Replace("c", "(");
            x = x.Replace("g", "9");
            x = x.Replace("k", "|<");
            x = x.Replace("o", "0");
            x = x.Replace("s", "5");
            x = x.Replace("d", "|)");
            x = x.Replace("h", "|-|");
            x = x.Replace("p", "|>");
            x = x.Replace("l", "1");
            x = x.Replace("t", "7");
            x = x.Replace("x", "><");
            x = x.Replace("u", "|_|");
            x = x.Replace("v", @"\/");
            x = x.Replace("m", @"|\/|");
            x = x.Replace("w", @"\/\/");
            x = x.Replace("n", @"|\|");
            x = x.Replace("y", "'/");

            return x;
        }
    }
}

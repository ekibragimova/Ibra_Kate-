using System;
using System.Globalization;
using System.Threading;

namespace номер23
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo uiCulture1 = CultureInfo.CurrentUICulture;
            Console.WriteLine("The current culture is {0}",uiCulture1.Name);
          
           Console. ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace проба
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathForRead = @"note1.txt"; // файл с исходными данными
            string pathForWrite = @"note2.txt"; // файл для записи таблицы биграмм


            string s = File.ReadAllText(pathForRead).Replace("\n", ""); 
            StreamWriter streamWriter = new StreamWriter(pathForWrite); 
            List<string> bigramms = new List<string>();
            string change = string.Empty;

            s = Regex.Replace(s, "[^а-яА-Яa-zA-Z]", "").ToUpper();
            if (Regex.IsMatch(s, "^[А-Яа-я]+$"))
            {
                change = "Ъ";
            }
            else
            {
                change = "Q";
            }

            for (int i = 0; i < s.Length - 1;)
            {
                string bigramm = string.Empty;
                if (s[i] != s[i + 1])
                {
                    bigramm = s[i].ToString() + s[i + 1].ToString();
                    i += 2;
                }
                else
                {
                    bigramm = s[i].ToString() + change;
                    i++;
                }
                bigramms.Add(bigramm);
                if (i >= s.Length - 1)
                {
                    bigramms.Add(s.Last().ToString() + change);
                }

            }
            Dictionary<string, int> bigrammsDict = new Dictionary<string, int>();
            HashSet<string> bigrammsSet = new HashSet<string>(bigramms);
            foreach (string bigramm in bigrammsSet)
            {
                bigrammsDict[bigramm] = bigramms.Count(b => b == bigramm);
            }

            //таблица биграмм
            foreach (var item in bigrammsDict)
            {
                streamWriter.WriteLine($"{item.Key}: {item.Value}");
            }
            streamWriter.Close();

            int count = 0;
            foreach (var item in bigrammsDict.OrderByDescending(pair => pair.Value))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
                count++;
                if (count > 5)
                    break;
            }

            Console.ReadLine();
        }
    }
}

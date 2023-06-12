using System;
using System.Linq;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string[] text = { "Любимая! Меня вы не любили. Не знали вы, что в сонмище людском я был, как лошадь, загнанная в мыле, пришпоренная смелым ездоком." };
        var result = FindWordsEndingInVowels(text);
        foreach (var item in result)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        var client1 = new Record(1, 2022, 4, 10);
        var client2 = new Record(1, 2022, 5, 20);
        var client3 = new Record(2, 2021, 8, 30);
        var client4 = new Record(2, 2021, 8, 40);
        var client5 = new Record(3, 2022, 1, 50);
        var client6 = new Record(3, 2021, 2, 60);
        var database = new List<Record>() { client1,client2,client3,client4,client5,client6};
        PrintTotalMonthsByClientAndYear(database);

    }
    static Dictionary<string, int> FindWordsEndingInVowels(string[] text) =>
        text.SelectMany(text => text.Split(new[] { ' ', '.', ',', '!', '?', ':', ';', '-', '(', ')' }, StringSplitOptions.RemoveEmptyEntries))
            .Where(w => "аеёиоуыэюя".Contains(w.Last()))
            .GroupBy(w => w.ToLower())
            .ToDictionary(g => g.Key, g => g.Count());

    static void PrintTotalMonthsByClientAndYear(List<Record> records)
    {
        var results = records.GroupBy(r => new { r.ClientID, r.Year })
                             .Select(g => new { ClientID = g.Key.ClientID, Year = g.Key.Year, TotalMonths = g.Select(r => r.Month).Distinct().Count() })
                             .OrderByDescending(r => r.Year)
                             .ThenBy(r => r.ClientID);

        foreach (var result in results)
        {
            Console.WriteLine($"Клиент с ID {result.ClientID} в {result.Year} году посещал {result.TotalMonths} месяц из 12");
        }
    }
    public struct Record
    {
        public int ClientID;
        public int Year;
        public int Month;
        public int Duration;

        public Record(int clientID, int year, int month, int duration) : this()
        {
            ClientID = clientID;
            Year = year;
            Month = month;
            Duration = duration;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
   
    public class Car
    {
        public string Brand;
        public readonly string VIN;
        public readonly CarBodyType BodyType;
        public decimal Cost;
        public readonly DateTime SaleDate;
        public string CustomerName;
        public int YearOfReveal;

        public int AgeOfCar
        {
            get
            {
                return DateTime.Now.Year - YearOfReveal;
            }
        }
        public Car(string brand, string vIN, CarBodyType bodyType, string saleDate, string customerName, decimal cost, int yearOfReveal)
        {
            Brand = brand;
            VIN = vIN;
            BodyType = bodyType;
            SaleDate = DateTime.Parse (saleDate);
            CustomerName=customerName;
            Cost = cost;
            YearOfReveal = yearOfReveal;
        }
        public override string ToString()
        {
            return $"{Brand} {VIN}";
        }

        public void PrintInfo()
        {
            Console.WriteLine(this);

            var bodyType = "";
            switch (BodyType)
            {
                case CarBodyType.Sedan:
                    bodyType = "Седан";
                    break;
                case CarBodyType.Hetchback:
                    bodyType = "Хэтчбэк";
                    break;
                case CarBodyType.Universal:
                    bodyType = "Универсал";
                    break;
                case CarBodyType.Cabriolette:
                    bodyType = "Кабриолет";
                    break;
            }
            Console.WriteLine($" Тип кузова:{BodyType}. Год выпуска:{YearOfReveal}.полное имя покупапателя:{ CustomerName}. Цена:{ Cost}. Дата продажи{SaleDate}. Возраст машины {AgeOfCar}");
        }

    }
}

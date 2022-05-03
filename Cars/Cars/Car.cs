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
        public string SaleDate;
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
            SaleDate = saleDate;
            CustomerName=customerName;
            Cost = cost;
            YearOfReveal = yearOfReveal;
        }
        public override string ToString()
        {
            return $"{Brand} {VIN}";
        }

        public virtual string [] GetInfo()
        {
            var info = new string[2];
            info[0] = ToString(); 

            var bodyType = "";
            switch (BodyType)
            {
                case CarBodyType.Sedan:
                    bodyType ="Седан";
                    break;
                case CarBodyType.Hetchback:
                    bodyType ="Хэтчбэк";
                    break;
                case CarBodyType.Universal:
                    bodyType ="Универсал";
                    break;
                case CarBodyType.Cabriolette:
                    bodyType ="Кабриолет";
                    break;
            }
            info[1] =$"Тип кузова: {BodyType}. Год выпуска: {YearOfReveal}. Полное имя покупапателя: {CustomerName}. Цена: {Cost}. Дата продажи: {SaleDate}. Возраст машины: {AgeOfCar}";
            return info;
        }
       

    }
}

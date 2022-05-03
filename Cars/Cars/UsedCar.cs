using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class UsedCar: Car
    {
        public int Mileage;
        public string Condition;

        public UsedCar(string brand, string vIN, CarBodyType bodyType, string saleDate, string customerName, decimal cost, int yearOfReveal, int mileage, string condition) :
            base(brand, vIN, bodyType, saleDate, customerName, cost, yearOfReveal)
        {
            Mileage = mileage;
            Condition = condition;
        }
        public override string[] GetInfo()
        {
            string[] info = base.GetInfo();
            info[1] += $". Пробег: { Mileage}. Состояние: {Condition}";
            return info;
        }
    }
}

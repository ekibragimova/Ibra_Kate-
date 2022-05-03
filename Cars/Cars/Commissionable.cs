using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
   public class Commissionable: UsedCar
    {
        public string FullName;
        public string CustomerAdress;
        public int ContractNumber;

        public Commissionable(string brand, string vIN, CarBodyType bodyType, string saleDate, string customerName, 
            decimal cost, int yearOfReveal, int mileage, string condition, string fullName,string customerAdress, int contractNumber): 
            base(brand, vIN, bodyType, saleDate, customerName, cost, yearOfReveal, mileage, condition)
        {
            FullName = fullName;
            CustomerAdress = customerAdress;
            ContractNumber = contractNumber;
        }
        public override string[] GetInfo()
        {
            string[] info = base.GetInfo();
            info[1] += $". Полное имя: {FullName}, Адресс покупателя: {CustomerAdress}, Номер контракта: {ContractNumber}";
            return info;
        }
    }
}

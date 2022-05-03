using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public class NewCar : Car
    {
        public string MakerFactory;
        public string GuarantyPeriod;

        public NewCar(string makerFactory, string guarantyPeriod) : base("Lada", "dddsss444", CarBodyType.Sedan, "23.03.2020", "Anna", 3000000, 2017) 
        {
            MakerFactory = makerFactory;
            GuarantyPeriod = guarantyPeriod;
        }

        public override string[] GetInfo()
        {
            string[] info = base.GetInfo();
            info[1] += $". Завод производитель: { MakerFactory}. Гарантийный период: { GuarantyPeriod}"; 
            return info;
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars;
using NUnit.Framework;


namespace Cars.UnitTests
{
    [TestFixture]
    public class CarUnitTest
    {
        [Test]
        public void ConstructorTest()
        {
            var lada = CreateTestCar();

            Assert.AreEqual("Lada", lada.Brand);
            Assert.AreEqual(2017,lada.YearOfReveal);
            Assert.AreEqual("dddsss444", lada.VIN);
            Assert.AreEqual(CarBodyType.Sedan, lada.BodyType);
            Assert.AreEqual(3000000, lada.Cost);
            Assert.AreEqual("23.03.2020", lada.SaleDate);
            Assert.AreEqual("Anna", lada.CustomerName);
        }
        [Test]
        public void ToString_Car_BrandSpaceVIN() 
        { 
            var  lada = CreateTestCar();
            Assert.AreEqual("Lada dddsss444", lada.ToString());
        } 
        private Car CreateTestCar() 
        { 
            return new Car("Lada", "dddsss444", CarBodyType.Sedan, "23.03.2020", "Anna",3000000, 2017); 
        } 
        [Test]
      public void GetInfo_Car_TwoStringsInfo()
        {
            var car = CreateTestCar();
            var info = car.GetInfo();
             
            Assert.AreEqual(2, info.Length);
            Assert.AreEqual("Lada dddsss444", info[0]);
            Assert.AreEqual($"Тип кузова: Sedan. Год выпуска: 2017. Полное имя покупапателя: Anna. Цена: 3000000. Дата продажи: 23.03.2020. Возраст машины: 5", info[1]);
        }
        [Test]
        public void NewCar_TwoString()
        {
            var NewCar = CreateTestNewCar();
            var info = NewCar.GetInfo();

            Assert.AreEqual($"Тип кузова: Sedan. Год выпуска: 2017. Полное имя покупапателя: Anna. Цена: 3000000. Дата продажи: 23.03.2020. Возраст машины: 5. Завод производитель: Урал Аз. Гарантийный период: 2", info[1]);
        }
        private NewCar CreateTestNewCar()
        {
            return new NewCar("Урал Аз", "2");
        }
        private UsedCar CreateTestUsedCar()
        {
            return new UsedCar("Lada", "dddsss444", CarBodyType.Sedan, "23.03.2020", "Anna", 3000000, 2017, 100000, "хорошее");
        }
        [Test]
        public void UsedCar_ToString()
        {
            var UsedCar = CreateTestUsedCar();
            var info = UsedCar.GetInfo();

            Assert.AreEqual("Тип кузова: Sedan. Год выпуска: 2017. Полное имя покупапателя: Anna. Цена: 3000000. Дата продажи: 23.03.2020. Возраст машины: 5. Пробег: 100000. Состояние: хорошее", info[1]);
        }
        [Test]
        public void Commissionable_ToString()
        {
            var Commissionable = CreateTestCommissionable();
            var info = Commissionable.GetInfo();

            Assert.AreEqual("Тип кузова: Sedan. Год выпуска: 2017. Полное имя покупапателя: Anna. Цена: 3000000. Дата продажи: 23.03.2020. Возраст машины: 5. Пробег: 100000. Состояние: хорошее. Полное имя: Иванова Анна Александровна, Адресс покупателя: Большакова, 55, Номер контракта: 123", info[1]);
        }
        private Commissionable CreateTestCommissionable()
        {
            return new Commissionable("Lada", "dddsss444", CarBodyType.Sedan, "23.03.2020", "Anna", 3000000, 2017, 100000, "хорошее", "Иванова Анна Александровна", "Большакова, 55", 123);
        }

    }
}

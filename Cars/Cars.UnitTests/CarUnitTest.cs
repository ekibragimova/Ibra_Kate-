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
            Assert.AreEqual("23.03.2020", lada.SaleDate.ToShortDateString());
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
     
    }
}

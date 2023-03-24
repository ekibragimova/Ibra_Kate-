using ConsigmentStruct;

namespace ConsigmentTests
{
    [TestFixture]
    public class ConsigmentTests
    {
        [Test]
        public void ConstructorTest()
        {
            var consigment = new Consigment(21, 18.5);
            Assert.That(consigment.Quantity, Is.EqualTo(21));
            Assert.That(consigment.Price, Is.EqualTo(18.5));
        }
        [TestCase(-30)]
        public void QuantitySet_NegativeValue_ArgumentException(int val)
        {
            var consigment = new Consigment();
            Assert.That(() => consigment.Quantity = val, Throws.ArgumentException);
        }
        [TestCase(-30.99)]
        public void PriceSet_NegativeValue_ArgumentException(double val)
        {
            var consigment = new Consigment();
            Assert.That(() => consigment.Price = val, Throws.ArgumentException);
        }
        [TestCase(15, 42.47, 637.05)]
        [TestCase(0, 0, 0)]
        public void CostTest(int quantity, double price, double result)
        {
            var consgiment = new Consigment(quantity, price);
            Assert.That(consgiment.Cost, Is.EqualTo(result));
        }
        [TestCase(15, 42.47, "15 шт. по 42,47 руб.\"")]
        [TestCase(0, 0, "0 шт. по 0 руб.\"")]
        [TestCase(42, 18, "42 шт. по 18 руб.\"")]
        public void ToStringTest(int quantity, double price, string result)
        {
            var consigment = new Consigment(quantity, price);
            Assert.That(consigment.ToString(), Is.EqualTo(result));
        }
        [TestCase(30, 30, 30, 30, true)]
        [TestCase(30, 15, 30, 30, false)]
        public void Equals_TwoConsigments_ExpectedResult(int quantity1, double price1, int quantity2, double price2, bool result)
        {
            var consigment1 = new Consigment(quantity1, price1);
            var consigment2 = new Consigment(quantity2, price2);
            Assert.That(consigment1.Equals(consigment2), Is.EqualTo(result));
        }
        [Test]
        public void Equals_WrongArgument_ArgumentException()
        {
            var consigment = new Consigment();
            var smth = new object();
            Assert.That(() => consigment.Equals(smth), Throws.ArgumentException);
        }
        [Test]
        public static void GetHashCodeTest()
        {
            var x = new Consigment(45, 18);
            var y = new Consigment(45, 18);
            var z = new Consigment(40, 45);
            Assert.That(x.Equals(y), Is.True);
            Assert.That(x.Equals(z), Is.False);
        }
        [Test]
        public static void ComparisonTest()
        {
            var x = new Consigment(45, 18);
            var y = new Consigment(45, 18);
            var z = new Consigment(10, 45);
            Assert.That(x == y, Is.True);
            Assert.That(x != y, Is.False);
            Assert.That(x == z, Is.False);
            Assert.That(x != z, Is.True);
        }
        [TestCase(30, 40, 20, 40, 50, 40)]
        [TestCase(30, 40, 0, 40, 30,40)]
        public void AdditionTest(
        int quantity1, int price1,
        int quantity2, int price2,
        int resultQuantity, int resultPrice)
        {
            var consigment1 = new Consigment(quantity1, price1);
            var consigment2 = new Consigment(quantity2, price2);
            var result = new Consigment(resultQuantity, resultPrice);
            Assert.That(consigment1 + consigment2, Is.EqualTo(result));
        }
        [TestCase(30, 40, 0, 30)]
        public void AdditionTest_ArgumentException(
        int quantity1, int price1,
        int quantity2, int price2)
        {
            var consigment1 = new Consigment(quantity1, price1);
            var consigment2 = new Consigment(quantity2, price2);
            Assert.That(() => consigment1 + consigment2, Throws.ArgumentException);
        }
        [TestCase(30, 40, 20, 40, 10, 40)]
        [TestCase(30, 40, 0, 40, 30, 40)]
        public void DecreaseTest(
        int quantity1, int price1,
        int quantity2, int price2,
        int resultQuantity, int resultPrice)
        {
            var consigment1 = new Consigment(quantity1, price1);
            var consigment2 = new Consigment(quantity2, price2);
            var result = new Consigment(resultQuantity, resultPrice);
            Assert.That(consigment1 - consigment2, Is.EqualTo(result));
        }
        [TestCase(40, 40, 40, 30)]
        [TestCase(10, 30, 40, 30)]
        public void DecreaseTest_ArgumentException(
        int quantity1, int price1,
        int quantity2, int price2)
        {
            var consigment1 = new Consigment(quantity1, price1);
            var consigment2 = new Consigment(quantity2, price2);
            Assert.That(() => consigment1 - consigment2, Throws.ArgumentException);
        }
    } 
}
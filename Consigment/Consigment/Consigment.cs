using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsigmentStruct
{
    public struct Consigment
    {
        int quantity;
        public int Quantity
        {
            get => quantity;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Количество единиц товара должно быть неотрицательным");
                quantity = value;
            }
        }
        double price;
        public double Price
        {
            get => price;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Количество единиц товара должно быть неотрицательным");
                price = Math.Round(value, 2);
            }
        }
        public double Cost
        {
            get => Math.Round((Price * Quantity),2);
        }
        public Consigment(int quantity, double price) : this()
        {
            Quantity = quantity;
            Price = price;
        }
        public override string ToString() => $"{Quantity} шт. по {Price} руб.\"";
        public override bool Equals(object obj)
        {
            if (obj is Consigment)
                return (Quantity == ((Consigment)obj).Quantity) && (Price == ((Consigment)obj).Price);
            throw new ArgumentException("Объект для сравнения не является партией товара");
        }
        public override int GetHashCode() => Cost.GetHashCode();
        public static bool operator ==(Consigment x, Consigment y) => x.Equals(y);
        public static bool operator !=(Consigment x, Consigment y) => !x.Equals(y);
        public static Consigment operator +(Consigment x, Consigment y)
        {
            if (x.Price != y.Price)
                throw new ArgumentException("При сложении цены товаров должны быть одинаковыми!");
            var result = new Consigment(x.Quantity + y.Quantity, x.Price);
            return result;
        }
        public static Consigment operator -(Consigment x, Consigment y)
        {
            if ((x.Price != y.Price) || (x.Quantity < y.Quantity))
                throw new ArgumentException("При вычитании цены товаров должны быть одинаковыми, а вычитаемое меньше уменьшаемого!");
            var result = new Consigment(x.Quantity - y.Quantity, x.Price);
            return result;
        }
    }
}

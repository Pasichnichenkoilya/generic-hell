using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public abstract class Product : IProduct
    {
        private static float totalPrice;
        private static int productsCount;

        protected string name;
        protected float price;

        public string GetName() => name;

        public float GetPrice() => price;

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetPrice(float price)
        {
            if (price < 0)
            {
                throw new PriceLessThanZeroException(price, $"invalid price: {price}");
            }
            this.price = price;
        }

        static Product()
        {
            totalPrice = 0;
            productsCount = 0;
        }

        public Product(string name = "no name", float price = 0f)
        {
            SetName(name);
            SetPrice(price);

            productsCount++;
            totalPrice += price;
        }

        public override string ToString()
        {
            return $"Name: {name}\n" +
                $"Price: {price}";
        }

        public static float GetAverageProductPrice()
        {
            return totalPrice / productsCount;
        }
    }
}

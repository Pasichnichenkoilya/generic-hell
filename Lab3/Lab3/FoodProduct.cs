using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class FoodProduct : Product, IFoodProduct
    {
        private DateTime expireDate;

        public DateTime GetExpireDate() => expireDate;

        public void SetExpireDate(DateTime expireDate)
        {
            this.expireDate = expireDate;
        }

        public FoodProduct() { }

        public FoodProduct(string name, float price, DateTime expireDate) : base(name, price)
        {
            SetExpireDate(expireDate);
        }

        public override string ToString()
        {
            return $"{base.ToString()}\n" +
                $"Expire date: {expireDate.ToShortDateString()}";
        }
    }
}

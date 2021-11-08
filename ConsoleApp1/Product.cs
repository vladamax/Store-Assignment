using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Product
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public float Price { get; set; }

        public abstract float GetDiscountPercentage(DateTime date);

        public abstract string getDescription();

        public string getTotalPrice(float quantity)
        {
            return "\n" + quantity + " x $" + this.Price + " = $" + quantity * Price;
        }
    }
}

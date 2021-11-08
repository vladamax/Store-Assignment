using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Food : Product
    {
        public DateTime ExpDate { get; set; }

        public Food(string name, string brand, float price, DateTime expDate)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.ExpDate = expDate;
        }

        public override float GetDiscountPercentage(DateTime dt)
        {
            if ((this.ExpDate - dt).Days < 5)
            {
                if ((this.ExpDate - dt).Days < 1)
                {
                    return 50;
                }
                return 10;
            }
            return 0;
        }

        public override string getDescription()
        {
            return this.Name + " - " + this.Brand;
        }
    }
}
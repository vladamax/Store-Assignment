using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Clothes : Product
    {
        public string Color { get; set; }
        public ClotheSize Size { get; set; }

        public Clothes(string name, string brand, float price , string color , ClotheSize size)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Color = color;
            this.Size = size;
        }

        public override float GetDiscountPercentage(DateTime date)
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
                return 0;
            return 10;
        }

        public override string getDescription()
        {
            return this.Name + " " + this.Brand + " " + this.Size + " " + this.Color;
        }
    }
}

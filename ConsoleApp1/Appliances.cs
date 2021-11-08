using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Appliances : Product
    {
        public string Model { get; set; }
        public DateTime ProductionDate { get; set; }
        public float Weight { get; set; }

        public Appliances(string name, string brand, float price, string model, DateTime productionDate, float weight)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Model = model;
            this.ProductionDate = productionDate;
            this.Weight = weight;
        }

        public override float GetDiscountPercentage(DateTime dt)
        {
            if (this.Price > 999)
                if (dt.DayOfWeek == DayOfWeek.Sunday || dt.DayOfWeek == DayOfWeek.Saturday)
                {
                    return 5;
                }
            return 0;
        }

        public override string getDescription()
        {
            return this.Name + " " + this.Brand + " " + this.Model;
        }
    }
}

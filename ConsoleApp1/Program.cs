using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime purchaseDateTime;
            purchaseDateTime = DateTime.ParseExact("2021-06-14 12:34:56" , "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

            Food apple = new Food("apple", "BrandA", 1.5f, Convert.ToDateTime("2021-06-14"));
            Beverage milk = new Beverage("milk", "BrandM", 0.99f, Convert.ToDateTime("2022-02-02"));
            Clothes tShirt = new Clothes("T - shirt", "BrandT", 15.99f, "violet", ClotheSize.M);
            Appliances laptop = new Appliances("laptop", "BrandL", 2345f, "ModelL", Convert.ToDateTime("2021-03-03"), 1125);

            Cart one = new Cart();
            one.AddItem(apple, 2.45f);
            one.AddItem(milk, 3);
            one.AddItem(tShirt, 2);
            one.AddItem(laptop, 1);

            Cashier cashier = new Cashier();
            Console.WriteLine(cashier.Purchase(one, purchaseDateTime));
        }
    }
}

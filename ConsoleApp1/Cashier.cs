using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Cashier
    {
        public string Purchase(Cart cart, DateTime dt)
        {
            float total = 0;
            float totalDiscount = 0;
            StringBuilder sb = new StringBuilder();
            sb.Append("Date: " + dt + "\n\n---Products---\n\n");

            foreach (var p in cart.GetCartItems())
            {
                var prod = p.Product;
                float quan = p.Quantity;
                total += quan*prod.Price;
                sb.Append(prod.getDescription());
                sb.Append(prod.getTotalPrice(quan));

                var discountPerc = prod.GetDiscountPercentage(dt);
                if(discountPerc>0)
                {
                    float discount = quan * prod.Price * discountPerc / 100;
                    sb.Append("\n#discount " + discountPerc + "% -$" + discount + "\n\n");
                    totalDiscount += discount;
                }
                sb.Append("\n\n");
            }
            sb.Append("-----------------------------------------------------------------------------------\n\n");
            sb.Append("SUBTOTAL: " + total + "\n");
            sb.Append("DISCOUNT: " + totalDiscount + "\n\n");
            sb.Append("TOTAL: " + (total-totalDiscount));
            return sb.ToString();
        }
    }
}

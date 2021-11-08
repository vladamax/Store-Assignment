using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Cart
    {
        public List<CartItem> cart = new List<CartItem>();

        public void AddItem(Product p , float qua)
        {
            cart.Add(new CartItem(p, qua));
        }

        public List<CartItem> GetCartItems()
        {
            return cart;
        }

        public class CartItem
        {
            public Product Product { get; set; }
            public float Quantity { get; set; }

            public CartItem(Product p , float q)
            {
                this.Product = p;
                this.Quantity = q;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce.Models
{
    public class CartModel
    {
      public List<Cart> cartInfo = new List<Cart>();

        public void addToCart(Cart prod)
        {
            cartInfo.Add(prod);
           // return cartInfo.IndexOf(prod);
        }
        public string checkExist(string name)
        {
            string status = "not found";

            foreach (Cart item in cartInfo)
            {
                if (name == item.Description)
                {
                    item.Quantity++;
                    status = "found";
                }

            }
            return status;
        }

    }
}

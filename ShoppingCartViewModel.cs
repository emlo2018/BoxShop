using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoxShop.Models
{
    public class ShoppingCartViewModel
    {
  
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }

        internal static void Add(ShoppingCartViewModel cartItem)
        {
            throw new NotImplementedException();
        }
    }
}
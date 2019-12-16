using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BoxShop.Models
{
    public class CartViewModel
    {
        public Product Product { get; set; }

        public int Amount { get; set; }
    }
}
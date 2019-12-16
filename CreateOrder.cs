using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoxShop.Models
{
    public class CreateOrder
    {
        public int CreateOrderId { get; set; }
        public int OrderId { get; set; }

        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

      
    }
}




   
       
    
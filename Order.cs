using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BoxShop.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public decimal Total { get; set; }
        public System.DateTime OrderDate { get; set; }
        public virtual List<OrderDetail> OrderDetails { get; set; }

        public string CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public virtual ApplicationUser Customer { get; set; }
    }
}
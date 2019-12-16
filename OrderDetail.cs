using System.ComponentModel.DataAnnotations.Schema;

namespace BoxShop.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }

        public int ProductId { get; set; }
        public string ImgageUrl { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
       
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }

        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }
    }
}
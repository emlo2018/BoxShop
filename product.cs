using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;

namespace BoxShop.Models
{
    public class Product
    {

      
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }


        public string ImageUrl { get; set; }

        public int ProductTypeID { get; set; }

        [ForeignKey("ProductTypeID")]
        public virtual ProductType Type { get; set; }


    }
}
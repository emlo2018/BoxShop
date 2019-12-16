using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BoxShop.Models
{
    public class ProductType
    {
       // [Authorize]

        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
    }
}
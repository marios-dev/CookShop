using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CookShopOnline.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Display(Name="Product")]
        public string ProductName { get; set; }
        public string Description { get; set; }
        //For future implementation  to add products that are not groceries
        // public ProductType ProductType { get; set; }
        public string ImagePath { get; set; }
        public decimal Price { get; set; }
    }
}
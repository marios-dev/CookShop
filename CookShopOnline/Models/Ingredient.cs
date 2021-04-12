using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CookShopOnline.Models
{
    public class Ingredient
    {
        public int ID { get; set; }

        [Display(Name = "Category")]
        public int IngredientCategoryID { get; set; }
        public IngredientCategory IngredientCategory { get; set; }

        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
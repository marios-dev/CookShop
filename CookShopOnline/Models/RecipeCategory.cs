using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CookShopOnline.Models
{
    public class RecipeCategory
    {
        public int ID { get; set; }

        [Display(Name = "Category")]
        public string Descreption { get; set; }
        public ICollection<Recipe> Recipes { get; set; }
    }
}
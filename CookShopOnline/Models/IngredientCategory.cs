using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CookShopOnline.Models
{
    public class IngredientCategory
    {
        public int ID { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Category must have a length between 3 and 50 characters.")]
        [Display(Name = "Category")]
        public string Description { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
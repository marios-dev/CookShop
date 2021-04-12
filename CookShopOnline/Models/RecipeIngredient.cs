using CookShopOnline.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CookShopOnline.Models
{
    public class RecipeIngredient
    {
        [Key, Column(Order = 0)]
        public int RecipeID { get; set; }
        public Recipe Recipe { get; set; }

        [Key, Column(Order = 1)]
        public int IngredientID { get; set; }
        public Ingredient Ingredient { get; set; }

        public double? Quantity { get; set; }

        public MeasuringUnit? MeasuringUnit { get; set; }
    }
}
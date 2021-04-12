using CookShopOnline.Enums;
using CookShopOnline.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CookShopOnline.Models
{
    public class Recipe
    {
        public int ID { get; set; }

        [Display(Name = "Recipe")]
        public string RecipeName { get; set; }

        [DataType(DataType.MultilineText)]
        public string Instructions { get; set; }
        public string ActiveTime { get; set; }
        public string TotalTime { get; set; }
        public DifficultyLevel DifficultyLevel { get; set; }

        [DataType(DataType.MultilineText)]
        public string Tips { get; set; }
        public string VideoUrl { get; set; }
        public string ImageUrl { get; set; }
        public int RecipeCategoryID { get; set; }
        public RecipeCategory RecipeCategory { get; set; }
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; }
        [NotMapped]

        [Display(Name = "Ingredients")]
        public List<Product> Products { get; set; }

    }
}
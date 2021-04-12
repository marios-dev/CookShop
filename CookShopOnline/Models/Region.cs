using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CookShopOnline.Models
{
    public class Region
    {
        public int ID { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Region must have a length between 3 and 50 characters.")]
        [Display(Name = "Region")]
        public string RegionName { get; set; }

        public List<City> Cities { get; set; }
    }
}
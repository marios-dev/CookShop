using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CookShopOnline.Models
{
    public class Country
    {
        public int ID { get; set; }

        [StringLength(5, MinimumLength = 2, ErrorMessage = "Country Code must have a length be between 2 and 5 characters")]
        [Display(Name = "Country Code")]
        public string CountryCode { get; set; }

        [StringLength(50, MinimumLength = 2, ErrorMessage = "Country must have a length between 2 and 50 characters")]
        [Display(Name = "Country")]
        public string CountryName { get; set; }
        public List<Region> Regions { get; set; }
    }
}
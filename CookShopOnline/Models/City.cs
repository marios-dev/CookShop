using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CookShopOnline.Models
{
    public class City
    {
        public int ID { get; set; }

        [Display(Name = "City")]
        public string Name { get; set; }
        //public int RegionID { get; set; }
        //public Region Region { get; set; }
    }
}
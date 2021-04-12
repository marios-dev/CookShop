using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CookShopOnline.Models
{
    public class Address
    {
        public int ID { get; set; }

        [StringLength(100, MinimumLength = 1, ErrorMessage = "The address cannot be empty or exceed a maximum length of 100 characters.")]
        [Display(Name = "Address")]
        public string Street { get; set; }

        [StringLength(12, MinimumLength = 5, ErrorMessage = "Postal code must have a length between 5 and 12 characters.")]
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }

        [StringLength(100, ErrorMessage = "Address Details cannot exceed a maximum length of 100 characters.")]
        [Display(Name = "Address Details")]
        public string Details { get; set; }

        [Display(Name = "Region")]
        public int RegionID { get; set; }
        public Region Region { get; set; }

        [Display(Name = "City")]
        public int CityID { get; set; }
        public City City { get; set; }

        [Display(Name = "Country")]
        public int CountryID { get; set; }
        public Country Country { get; set; }


        [NotMapped]
        public string AddressInformation
        {
            get
            {
                return $"{Street}, {PostalCode}, {City.Name}, {Region.RegionName}, {Country.CountryName}";
            }
        }

    }
}
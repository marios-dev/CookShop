using CookShopOnline.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CookShopOnline.ViewModels
{
    [NotMapped]
    public class CustomerAddressTelephoneViewModel
    {
        public Customer Customer { get; set; }
        public Address Address { get; set; }
        public List<City> Cities { get; set; }
        public List<Region> Regions { get; set; }
        public List<Country> Countries { get; set; }
        public TelephoneNumber TelephoneNumber { get; set; }
        public RegisterViewModel RegisterViewModel { get; set; }
    }
}
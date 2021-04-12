using CookShopOnline.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CookShopOnline.ViewModels
{
    [NotMapped]
    public class EditCustomerAddressTelephoneViewModel
    {
        public Customer Customer { get; set; }
        public Address Address { get; set; }
        public List<City> Cities { get; set; }
        public List<Region> Regions { get; set; }
        public List<Country> Countries { get; set; }
        public TelephoneNumber TelephoneNumber { get; set; }
        //public List<Order> Orders { get; set; }
        //public ChangePasswordViewModel ChangePasswordViewModel { get; set; }
    }
}
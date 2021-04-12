using CookShopOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CookShopOnline.ViewModels
{
    public class SingleCustomerAddressTelephoneViewModel
    {
        public Customer Customer { get; set; }
        public Address Address { get; set; }
        public City City { get; set; }
        public Region Region { get; set; }
        public Country Country { get; set; }
        public TelephoneNumber TelephoneNumber { get; set; }
    }
}
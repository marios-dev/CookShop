using CookShopOnline.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CookShopOnline.ViewModels
{
    public class ShoppingCartViewModel
    {
        [Key]
        public int ID { get; set; }
        public List<CartItem> CartItems { get; set; }
        public decimal CartTotalPrice { get; set; }
        public int CartTotalCount { get; set; }
    }
}
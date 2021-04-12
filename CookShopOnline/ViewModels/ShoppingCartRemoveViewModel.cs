using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CookShopOnline.ViewModels
{
    public class ShoppingCartRemoveViewModel
    {
        public string Message { get; set; }
        public decimal CartTotalPrice { get; set; }
        public int CartTotalCount { get; set; }
        public int ItemCount { get; set; }
        public int DeleteID { get; set; }
        public decimal LineTotal { get; set; }
    }
}
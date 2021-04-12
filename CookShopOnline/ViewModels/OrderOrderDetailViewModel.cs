using CookShopOnline.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CookShopOnline.ViewModels
{
    public class OrderOrderDetailViewModel
    {
        public Order Order { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        //public OrderDetail OrderDetail { get; set; }
    }
}
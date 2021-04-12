using CookShopOnline.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CookShopOnline.ViewModels
{
    [NotMapped]
    public class CustomerOrderDetailViewModel
    {
        public List<Order> AllOrdersPerCustomer { get; set; }
        public Order LastOrderPerCustomer { get; set; }
        public List<OrderDetail> LastOrderDetailsPerCustomer { get; set; }
        //public OrderDetail OrderDetail { get; set; }
        public Customer Customer { get; set; }
    }
}
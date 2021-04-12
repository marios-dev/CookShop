using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CookShopOnline.Models
{
    public class CartItem
    {
        [Key]
        public int RecordID { get; set; }
        // for anonymous shopping
        public string CartID { get; set; }
        public int ProductID { get; set; }
        public int Count { get; set; }
        public DateTime DateCreated { get; set; }
        public virtual Product Product { get; set; }
        public decimal LineTotal { get; set; }

    }
}
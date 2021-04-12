using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CookShopOnline.Models
{
    public class TelephoneNumber
    {
        public int ID { get; set; }

        [StringLength(20, ErrorMessage = "A telephone number must have a maximum length of 20 characters.")]
        public string Telephone1 { get; set; }

        [StringLength(20, ErrorMessage = "A telephone number must have a maximum length of 20 characters.")]
        public string Telephone2 { get; set; }

        [StringLength(20, ErrorMessage = "A telephone number must have a maximum length of 20 characters.")]
        public string Mobile { get; set; }
    }
}
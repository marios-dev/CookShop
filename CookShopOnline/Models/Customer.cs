using CookShopOnline.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CookShopOnline.Models
{
    public class Customer
    {
        [ScaffoldColumn(false)]
        public int ID { get; set; }

        [Display(Name = "Name")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Name must have a length between 2 and 50 characters")]
        public string FirstName { get; set; }

        [Display(Name = "Surname")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Surname must have a length between 2 and 50 characters")]
        public string LastName { get; set; }

        [Display(Name = "Birthday")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        //[Range(typeof(DateTime), "1/2/1930", "3/4/2015", ErrorMessage = "Value for {0} must be between {1} and {2}")]
        public DateTime DateOfBirth { get; set; }

        [ScaffoldColumn(false)]
        public bool SubscriptionState { get; set; } = false;

        [ScaffoldColumn(false)]
        [Display(Name = "Subscription active from")]
        public DateTime? SubscriptionStart { get; set; }

        [ScaffoldColumn(false)]
        [Display(Name = "Subscription active until")]
        public DateTime? SubscriptionEnd { get; set; }

        [ScaffoldColumn(false)]
        public int? AddressID { get; set; }
        [ScaffoldColumn(false)]
        public Address Address { get; set; }

        
        [ScaffoldColumn(false)]
        public int? TelephoneNumberID { get; set; }
        [ScaffoldColumn(false)]
        public TelephoneNumber TelephoneNumber { get; set; }

        [NotMapped]
        public string CustomerBirthday
        {
            get
            {
                return $"{DateOfBirth.Day}/{DateOfBirth.Month}/{DateOfBirth.Year}";
            }
        }

        [ScaffoldColumn(false)]
        public string AspNetUsersId { get; set; }
        [ScaffoldColumn(false)]
        public ApplicationUser User { get; set; }

        [NotMapped]
        public string UserName
        {
            get
            {
                return User.Email;
                //return $"{FirstName} {LastName}";
            }
        }

        [NotMapped]
        [ScaffoldColumn(false)]
        public ICollection<Order> Orders { get; set; } = null;
    }
}
using CookShopOnline.App_Start;
using CookShopOnline.Models;
using CookShopOnline.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using PayPal.Api;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CookShopOnline.Controllers
{
    [Authorize]
    public class CheckOutController : Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();

        //GET: CheckOut
        public ActionResult CheckOutAndPayment()
        {

            var userId = User.Identity.GetUserId();
            if (userId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var customers = db.Customers.ToList();

            var customer = customers.Find(c => c.AspNetUsersId == userId);
            var customerID = customers.Where(c => c.AspNetUsersId == userId).Select(c => c.ID).FirstOrDefault();

            var addresses = db.Addresses.ToList();
            var customerAddressID = customers.Where(c => c.ID == customerID).Select(c => c.AddressID).FirstOrDefault();
            var address = addresses.Find(a => a.ID == customerAddressID);

            var telephones = db.TelephoneNumbers.ToList();
            var customerTelephoneID = customers.Where(c => c.ID == customerID).Select(c => c.TelephoneNumberID).FirstOrDefault();
            var telephone = telephones.Find(t => t.ID == customerTelephoneID);

            var cities = db.Cities.ToList();
            var customerAddressCityID = addresses.Where(a => a.ID == customerAddressID).Select(a => a.CityID).FirstOrDefault();
            var city = cities.Find(c => c.ID == customerAddressCityID);

            var countries = db.Countries.ToList();
            var customerAddressCountryID = addresses.Where(a => a.ID == customerAddressID).Select(a => a.CountryID).FirstOrDefault();
            var country = countries.Find(c => c.ID == customerAddressCountryID);

            var regions = db.Regions.ToList();
            var customerAddressRegionID = addresses.Where(c => c.ID == customerAddressID).Select(a => a.RegionID).FirstOrDefault();
            var region = regions.Find(r => r.ID == customerAddressRegionID);

            var viewModel = new SingleCustomerAddressTelephoneViewModel()
            {
                Customer = customer,
                Address = address,
                City = city,
                Region = region,
                Country = country,
                TelephoneNumber = telephone
            };
            return View(viewModel);
        }
        // apo8ukeush paraggelias me ton user sthn database
        [HttpPost]
        public ActionResult CheckOutAndPayment(FormCollection values)
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);
            var order = new CookShopOnline.Models.Order();

            TryUpdateModel(order);

            order.UserName = User.Identity.Name;
            order.OrderDate = DateTime.Now;
            order.Total = cart.GetTotal();
            db.Orders.Add(order);
            db.SaveChanges();

            cart.CreateOrder(order);
            //return PaymentWithPaypal();
            return RedirectToAction("Complete", new { id = order.OrderID });
            //return RedirectToAction("Complete", order);
        }
        
        //epalh8eush paraggelias me user gia na kalesoume to Paypal API me ta katallhla dedomena ths paraggelias
        public ActionResult Complete(int id)
        {
            // Validate customer owns this order
            bool isValid = db.Orders.Any(
                o => o.OrderID == id &&
                o.UserName == User.Identity.Name);

            //info gia shipping info sto paypal
            var userId = User.Identity.GetUserId();
            if (userId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var customers = db.Customers.ToList();
            var customerID = customers.Where(c => c.AspNetUsersId == userId).Select(c => c.ID).FirstOrDefault();
            var customerFirstName = customers.Where(c => c.ID == customerID).Select(c => c.FirstName).FirstOrDefault();
            var customerLastName = customers.Where(c => c.ID == customerID).Select(c => c.LastName).FirstOrDefault();
            var addresses = db.Addresses.ToList();
            var customerAddressID = customers.Where(c => c.ID == customerID).Select(c => c.AddressID).FirstOrDefault();
            var customerStreet = addresses.Where(a => a.ID == customerAddressID).Select(a => a.Street).FirstOrDefault();
            var customerPostalCode = addresses.Where(a => a.ID == customerAddressID).Select(a => a.PostalCode).FirstOrDefault();
            var countries = db.Countries.ToList();
            var addressCountryID = addresses.Where(a => a.ID == customerAddressID).Select(a => a.CountryID).FirstOrDefault();
            var customerCountry = countries.Where(c => c.ID == addressCountryID).Select(c => c.CountryCode).FirstOrDefault();
            var cities = db.Cities.ToList();
            var addressCityID = addresses.Where(a => a.ID == customerAddressID).Select(a => a.CityID).FirstOrDefault();
            var customerCity = cities.Where(c => c.ID == addressCityID).Select(c => c.Name).FirstOrDefault();

            //paypal method requirements for JSON
            var specifier = "F";
            var culture = CultureInfo.CreateSpecificCulture("en-CA");
            var totalPayment2 = db.Orders.Where(o => o.OrderID == id).Select(o => o.Total).FirstOrDefault();
            var total = totalPayment2.ToString(specifier, culture);
            var orderId = id.ToString();


            if (isValid)
            {
                return PaymentWithPaypal(total, orderId, customerFirstName, customerLastName, customerPostalCode, customerStreet, customerCountry, customerCity);
                //return SuccessOrder(id);
            }
            else
            {
                return View("Error");
            }
        }        

        public ActionResult PaymentWithPaypal(string total, string orderId, string customerFirstName, string customerLastName, string customerPostalCode, string customerStreet, string customerCountry, string customerCity, string Cancel = null)
        {
            APIContext apiContext = PaypalConfiguration.GetAPIContext();

            try
            {
                //A resource representing a Payer that funds a payment Payment Method as paypal  
                //Payer Id will be returned when payment proceeds or click to pay  
                string payerId = Request.Params["PayerID"];

                if (string.IsNullOrEmpty(payerId))
                {
                    //this section will be executed first because PayerID doesn't exist  
                    //it is returned by the create function call of the payment class  
                    // Creating a payment  
                    // baseURL is the url on which paypal sendsback the data.  
                    string baseURI = Request.Url.Scheme + "://" + Request.Url.Authority + "/CheckOut/PaymentWithPayPal?";
                    //here we are generating guid for storing the paymentID received in session  
                    //which will be used in the payment execution  
                    var guid = Convert.ToString((new Random()).Next(100000));
                    //CreatePayment function gives us the payment approval url  
                    //on which payer is redirected for paypal account payment  
                    var createdPayment = this.CreatePayment(apiContext, baseURI + "guid=" + guid, total, orderId, customerFirstName, customerLastName, customerPostalCode, customerStreet, customerCountry, customerCity);
                    //get links returned from paypal in response to Create function call  
                    var links = createdPayment.links.GetEnumerator();
                    string paypalRedirectUrl = null;
                    while (links.MoveNext())
                    {
                        Links lnk = links.Current;
                        if (lnk.rel.ToLower().Trim().Equals("approval_url"))
                        {
                            //saving the payapalredirect URL to which user will be redirected for payment  
                            paypalRedirectUrl = lnk.href;
                        }
                    }
                    // saving the paymentID in the key guid  
                    Session.Add(guid, createdPayment.id);

                    //return Redirect(paypalRedirectUrl);
                    return Redirect(paypalRedirectUrl);

                }
                else
                {
                    // This function exectues after receving all parameters for the payment  
                    //id = Convert.ToInt32(orderId);
                    var guid = Request.Params["guid"];
                    var executedPayment = ExecutePayment(apiContext, payerId, Session[guid] as string);

                    //If executed payment failed then we will show payment failure message to user  
                    if (executedPayment.state.ToLower() != "approved")
                    {
                        return View("FailureView");
                    }
                }
            }
            catch (Exception ex)
            {
                return View("FailureView");
            }
                        
            return RedirectToAction("CompleteOrder");
            
        }

        public ActionResult CompleteOrder()
        {
            // Get the logged in user's id
            var userId = User.Identity.GetUserId();
            // Get the customer that is linked with the current user
            Customer customer = db.Customers.ToList().FirstOrDefault(c => c.AspNetUsersId == userId);

            var user = db.Users.ToList().Find(u => u.Id == userId);

            // Get the order that is being proccessed
            var customerOrders = db.Orders.Where(o => o.UserName == user.Email).ToList();
            var customerOrderId = customerOrders.Select(c => c.OrderID).LastOrDefault();
            var orderDetails = db.OrderDetails.Where(o => o.OrderID == customerOrderId).ToList();
            // mark order as paid
            var order = customerOrders.LastOrDefault(o => o.OrderID == customerOrderId);
            order.IsPaid = true;
            db.SaveChanges();

            bool isUpgrade = false;

            if (orderDetails.Count() == 1)
            {
                // Check if the order is a subscription to premium
                isUpgrade = (orderDetails[0].ProductID == 46);
            }

            if (isUpgrade)
            {
                // Checks if the customer already has an active subscription
                if (customer.SubscriptionState)
                {
                    // If the customer is already subscribed, the subscription is prolonged by another year
                    customer.SubscriptionEnd = Convert.ToDateTime(customer.SubscriptionEnd).AddYears(1);
                }
                else
                {
                    // Get the User and Premium roles
                    var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
                    var userRole = roleManager.FindByName("User");
                    var premiumRole = roleManager.FindByName("Premium");

                    // Change customer's role from User to Premium
                    var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
                    userManager.RemoveFromRole(userId, userRole.Name);
                    userManager.AddToRole(userId, premiumRole.Name);

                    // Set _subscriptionState field value to true
                    customer.SubscriptionState = true;
                    // Set the values of the customer's subscription date properties
                    customer.SubscriptionStart = DateTime.Now;
                    customer.SubscriptionEnd = DateTime.Now.AddYears(1);
                }

                db.SaveChanges();

                return RedirectToAction("LogOffOnStateChange", "Account");
            }
            else
            {
                return RedirectToAction("OrderAfterPayPal", "Orders");
            }
        }

        private PayPal.Api.Payment payment;
        private Payment ExecutePayment(APIContext apiContext, string payerId, string paymentId)
        {
            var paymentExecution = new PaymentExecution()
            {
                payer_id = payerId
            };
            this.payment = new Payment()
            {
                id = paymentId
            };
            return this.payment.Execute(apiContext, paymentExecution);
        }
        // dhmiourgia plhrwmhs me ta katallhla dedomena ths paraggelias
        private Payment CreatePayment(APIContext apiContext, string redirectUrl, string totalPayment, string orderId, string customerFirstName, string customerLastName, string customerPostalCode, string customerStreet, string customerCountry, string customerCity)
        {
            var specifier = "F";
            var culture = CultureInfo.CreateSpecificCulture("en-CA");
            //CultureInfo us = new CultureInfo("en-US");
            var shippingAdress = new ShippingAddress()
            {
                postal_code = customerPostalCode,
                country_code = customerCountry,
                line1 = customerStreet,
                recipient_name = customerFirstName + " " + customerLastName,
                city = customerCity
            };
            var itemList = new ItemList()
            {
                items = new List<Item>(),
                shipping_address = shippingAdress
            };

            itemList.items.Add(new Item()
            {
                name = "product",
                currency = "EUR",
                price = totalPayment,
                quantity = "1",
                sku = "sku",
            });
            var payer = new Payer()
            {
                payment_method = "paypal"
            };
            // Configure Redirect Urls here with RedirectUrls object  
            var redirUrls = new RedirectUrls()
            {
                cancel_url = redirectUrl + "&Cancel=true",
                return_url = redirectUrl
            };
            //Adding Tax, shipping and Subtotal details
            var tax1 = Convert.ToDecimal(totalPayment, culture) * 13 / 100;
            var details = new Details()
            {
                tax = tax1.ToString(specifier, culture),
                subtotal = totalPayment
            };
            var total2 = Convert.ToDecimal(details.tax, culture) + Convert.ToDecimal(details.subtotal, culture);
            var amount = new Amount()
            {
                currency = "EUR",
                total = total2.ToString(specifier, culture),
                details = details
            };

            var transactionList = new List<Transaction>();
            // Adding description about the transaction  
            transactionList.Add(new Transaction()
            {
                description = "Transaction description", 
                invoice_number = Convert.ToString(new Random().Next(100000)),
                amount = amount,
                item_list = itemList,

            });
            this.payment = new Payment()
            {
                intent = "sale",
                payer = payer,
                transactions = transactionList,
                redirect_urls = redirUrls
            };
            // Create a payment using a APIContext  
            return this.payment.Create(apiContext);
        }
    }
}
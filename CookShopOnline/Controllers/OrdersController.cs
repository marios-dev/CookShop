using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CookShopOnline.Models;
using CookShopOnline.ViewModels;
using Microsoft.AspNet.Identity;

namespace CookShopOnline.Controllers
{
    public class OrdersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Orders
        public ActionResult Index()
        {
            return View();
        }

        // GET: Orders/Details/5
        public ActionResult OrderAfterPayPal()
        {
            var userId = User.Identity.GetUserId();
            if (userId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // Get the customer that is linked with the current user
            Customer customer = db.Customers.ToList().FirstOrDefault(c => c.AspNetUsersId == userId);

            //get user from Users list
            var user = db.Users.ToList().Find(u => u.Id == userId);

            //get user email from log in user
            var customerEmail = user.Email;

            //get All Orders from log in user
            var allOrdersPerCustomer = db.Orders.Where(o => o.UserName == customerEmail).ToList();

            //get last order from log in cusomer
            var orderLastPerCustomer = allOrdersPerCustomer.LastOrDefault();

            //get Last orderID from log in user
            var lastOrderPerCustomerID = allOrdersPerCustomer.Select(a => a.OrderID).LastOrDefault();

            //get last orderDetails  from log in user that has last order
            var lastOrderDetailsPerCustomer = db.OrderDetails.Where(o => o.OrderID == lastOrderPerCustomerID).ToList();

            var viewModel = new CustomerOrderDetailViewModel()
            {
                LastOrderPerCustomer = orderLastPerCustomer,
                Customer = customer,
                LastOrderDetailsPerCustomer = lastOrderDetailsPerCustomer,
            };
            return View("SuccessView", viewModel);
        }
        public ActionResult AllOrdersPerCustomer()
        {
            var userId = User.Identity.GetUserId();
            if (userId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            // Get the customer that is linked with the current user
            Customer customer = db.Customers.ToList().FirstOrDefault(c => c.AspNetUsersId == userId);

            //get user from Users list
            var user = db.Users.ToList().Find(u => u.Id == userId);

            //get user email from log in user
            var customerEmail = user.Email;

            //get All Orders from log in user
            var allOrdersPerCustomer = db.Orders.Include(a => a.OrderDetails).Where(o => o.UserName == customerEmail).ToList();

            //var successOrdersPerCustomer = allOrdersPerCustomer.Where(a => a.IsPaid == true).ToList();

            var viewModel = new CustomerOrderDetailViewModel()
            {
                AllOrdersPerCustomer = allOrdersPerCustomer
            };

            return View("AllOrdersPerCustomer", viewModel);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}

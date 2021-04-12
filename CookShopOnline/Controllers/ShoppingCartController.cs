using CookShopOnline.Models;
using CookShopOnline.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CookShopOnline.Controllers
{
    public class ShoppingCartController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ShoppingCart
        public ActionResult Index()
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);
            var viewModel = new ShoppingCartViewModel
            {
                CartItems = cart.GetCartItems(),
                CartTotalPrice = cart.GetTotal(),
                CartTotalCount = cart.GetCount()
            };
            return View(viewModel);
        }

        // apo8ukeush proiontos sthn cart
        public ActionResult AddToCart(int id, int count)
        {
            var addedProduct = db.Products.Single(p => p.ID == id);
            var cart = ShoppingCart.GetCart(this.HttpContext);
            cart.AddToCart(addedProduct, count);
            return RedirectToAction("Index");
        }
        // diagrafh proiontos apthn carta, kai eikonika mesw AJAX sto view model
        //AJAX : /ShoppingCart/RemoveFromCart/5
        [HttpPost]
        public ActionResult RemoveFromCart(int id)
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);
            string productName = db.CartItems.Single(p => p.RecordID == id).Product.ProductName;
            decimal productPrice = db.CartItems.Single(p => p.RecordID == id).Product.Price;
            int itemCount = cart.RemoveFromCart(id);
            decimal lineTotal = itemCount * productPrice;

            var results = new ShoppingCartRemoveViewModel
            {
                Message = Server.HtmlEncode(productName) + " has been removed from your shopping cart.",
                CartTotalPrice = cart.GetTotal(),
                CartTotalCount = cart.GetCount(),
                ItemCount = itemCount,
                LineTotal = lineTotal,
                DeleteID = id
            };
            return Json(results);
        }

        [HttpPost]
        public ActionResult SubstructQuantity(int id)
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);
            string productName = db.CartItems.Single(p => p.RecordID == id).Product.ProductName;
            decimal productPrice = db.CartItems.Single(p => p.RecordID == id).Product.Price;
            int itemCount = cart.SubstructQuantity(id);
            decimal lineTotal = itemCount * productPrice;

            var results = new ShoppingCartRemoveViewModel
            {
                Message = Server.HtmlEncode(productName) + "'s quantity has been reduced by 1.",
                CartTotalPrice = cart.GetTotal(),
                CartTotalCount = cart.GetCount(),
                ItemCount = itemCount,
                LineTotal = lineTotal,
                DeleteID = id
            };
            return Json(results);
        }

        [HttpPost]
        public ActionResult AddQuantity(int id)
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);
            string productName = db.CartItems.Single(p => p.RecordID == id).Product.ProductName;
            decimal productPrice = db.CartItems.Single(p => p.RecordID == id).Product.Price;
            int itemCount = cart.AddQuantity(id);
            decimal lineTotal = itemCount * productPrice;
            //decimal lineTotal = cart.RemoveFromCart2(id);

            var results = new ShoppingCartRemoveViewModel
            {
                Message = Server.HtmlEncode(productName) + "'s quantity has been increased by 1.",
                CartTotalPrice = cart.GetTotal(),
                CartTotalCount = cart.GetCount(),
                ItemCount = itemCount,
                LineTotal = lineTotal,
                DeleteID = id
            };
            return Json(results);
        }

        //GET: /Shopping/CartSummary
        [ChildActionOnly]
        /*The ChildActionOnly attribute ensures that an action method
         * can be called only as a child method from within a view*/

        // istoriko ths kartas agoras mesw perihghsh tou site
        public ActionResult CartSummary()
        {
            var cart = ShoppingCart.GetCart(this.HttpContext);

            ViewData["CartTotalCount"] = cart.GetCount();
            return PartialView("CartSummary");
        }
    }
}
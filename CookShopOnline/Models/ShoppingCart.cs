using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CookShopOnline.Models
{
    public class ShoppingCart
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        //[Key]
        string ShoppingCartID { get; set; }
        public const string CartItemsSessionKey = "CartID";
        public static ShoppingCart GetCart(HttpContextBase context)
        {
            var cart = new ShoppingCart();
            cart.ShoppingCartID = cart.GetCardID(context);
            return cart;
        }
        public static ShoppingCart GetCart(Controller controller)
        {
            return GetCart(controller.HttpContext);
        }
        // pros8esh proiontos sthn karta
        public void AddToCart(Product product, int count)
        {
            var cartItem = db.CartItems.SingleOrDefault(c => c.CartID == ShoppingCartID && c.ProductID == product.ID);
            if (cartItem == null)
            {
                cartItem = new CartItem
                {
                    ProductID = product.ID,
                    CartID = ShoppingCartID,
                    Count = count,
                    DateCreated = DateTime.Now,
                    LineTotal = count * product.Price
                };
                db.CartItems.Add(cartItem);
            }
            else
            {
                cartItem.LineTotal = count * product.Price;
            }
            db.SaveChanges();
        }
        // diagrafh proiontos apthn karta
        public int RemoveFromCart(int id)
        {
            var cartItem = db.CartItems.Single(c => c.CartID == ShoppingCartID && c.RecordID == id);
            int itemCount = 0;
            if (cartItem != null)
            {
                //if (cartItem.Count > 1)
                //{
                //    cartItem.Count--;
                //    itemCount = cartItem.Count;
                //}
                //else
                //{
                //    db.CartItems.Remove(cartItem);
                //}
                db.CartItems.Remove(cartItem);
                db.SaveChanges();
            }
            return itemCount;
        }

        public int SubstructQuantity(int id)
        {
            var cartItem = db.CartItems.Single(c => c.CartID == ShoppingCartID && c.RecordID == id);
            //int itemCount = cartItem.Count;
            if (cartItem != null)
            {
                if (cartItem.Count > 1)
                {
                    cartItem.Count--;
                }
                //else
                //{
                //    db.CartItems.Remove(cartItem);
                //}
                //db.CartItems.Remove(cartItem);
                db.SaveChanges();
            }
            return cartItem.Count;
        }

        public int AddQuantity(int id)
        {
            var cartItem = db.CartItems.Single(c => c.CartID == ShoppingCartID && c.RecordID == id);
            //int itemCount = cartItem.Count;
            if (cartItem != null)
            {

                cartItem.Count++;

                //else
                //{
                //    db.CartItems.Remove(cartItem);
                //}
                //db.CartItems.Remove(cartItem);
                db.SaveChanges();
            }
            return cartItem.Count;
        }

        // adeiasma kartas
        public void EmptyCart()
        {
            var cartItems = db.CartItems.Where(c => c.CartID == ShoppingCartID);
            foreach (var cartItem in cartItems)
            {
                db.CartItems.Remove(cartItem);
            }
            db.SaveChanges();
        }
        //lista apo proionta ths kartas
        public List<CartItem> GetCartItems()
        {
            return db.CartItems.Where(c => c.CartID == ShoppingCartID).ToList();
        }
        // a8roisma twn proiontwn se mia shopping cart
        public int GetCount()
        {
            int? count = (from cartItems in db.CartItems where cartItems.CartID == ShoppingCartID select (int?)cartItems.Count).Sum();
            return count ?? 0;
            //The null-coalescing operator ?? returns the value of
            //its left-hand operand if it isn't null; otherwise,
            //it evaluates the right-hand operand and returns
            //its result.
        }
        // teliko poso olwn twn proiontwn
        public decimal GetTotal()
        {
            decimal? total = (from cartItems in db.CartItems where cartItems.CartID == ShoppingCartID select (int?)cartItems.Count * cartItems.Product.Price).Sum();
            return total ?? decimal.Zero;
        }
        // apo8ukeush paraggelias sth bash mesw ths order detail kai adeiasma ths kartas meta thn apou8ukeush ths bashs
        public int CreateOrder(Order order)
        {
            decimal orderTotal = 0;
            var cartItems = GetCartItems();
            foreach (var item in cartItems)
            {
                var orderDetail = new OrderDetail
                {
                    ProductID = item.ProductID,
                    OrderID = order.OrderID,
                    UnitPrice = item.Product.Price,
                    Quantity = item.Count
                };
                orderTotal += (item.Count * item.Product.Price);
                db.OrderDetails.Add(orderDetail);
            }
            order.Total = orderTotal;
            db.SaveChanges();
            EmptyCart();
            return order.OrderID;
        }

        public string GetCardID(HttpContextBase context)
        {
            if (context.Session[CartItemsSessionKey] == null)
            {
                if (!string.IsNullOrWhiteSpace(context.User.Identity.Name))
                {
                    context.Session[CartItemsSessionKey] = context.User.Identity.Name;
                }
                else
                {
                    Guid tempCartID = Guid.NewGuid();
                    context.Session[CartItemsSessionKey] = tempCartID.ToString();
                }
            }
            return context.Session[CartItemsSessionKey].ToString();
        }
        // apo8ukeush sthn database twn proiontwn ths kartas me ton user pou epelekse ta proionta sthn karta
        public void MigrateCart(string userName)
        {
            var shoppingCart = db.CartItems.Where(c => c.CartID == ShoppingCartID);
            foreach (CartItem item in shoppingCart)
            {
                item.CartID = userName;
            }
            db.SaveChanges();
        }
    }
}
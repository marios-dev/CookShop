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
using Microsoft.AspNet.Identity.EntityFramework;
using PagedList;

namespace CookShopOnline.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Customers
        public ViewResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {

            ViewBag.CurrentSort = sortOrder;
            ViewBag.FirstNameSortParm = String.IsNullOrEmpty(sortOrder) ? "firstName_desc" : "";
            ViewBag.LastNameSortParm = String.IsNullOrEmpty(sortOrder) ? "lastName_desc" : "";
            ViewBag.DateOfBirthSortParm = sortOrder == "DateOfBirth" ? "dateOfBirth_desc" : "DateOfBirth";
            ViewBag.SubscriptionStartSortParm = sortOrder == "SubscriptionStart" ? "subscriptionStart_desc" : "SubscriptionStart";
            ViewBag.SubscriptionEndSortParm = sortOrder == "SubscriptionEnd" ? "subscriptionEnd_desc" : "SubscriptionEnd";
            ViewBag.SubscriptionEndSortParm = sortOrder == "SubscriptionEnd" ? "subscriptionEnd_desc" : "SubscriptionEnd";
            ViewBag.CountryNameSortParm = sortOrder == "CountryName" ? "countryName_desc" : "CountryName";
            ViewBag.RegionNameSortParm = sortOrder == "RegionName" ? "regionName_desc" : "RegionName";
            ViewBag.StreetParm = sortOrder == "Street" ? "street_desc" : "Street";
            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            ViewBag.CurrentFilter = searchString;

            var customers = db.Customers.Include(c => c.Address)
                .Include(c => c.TelephoneNumber)
                .Include(c => c.Address.Region)
                .Include(c => c.Address.Country);
            if (!String.IsNullOrEmpty(searchString))
            {
                customers = customers.Where(c => c.FirstName.Contains(searchString)
                     || c.LastName.Contains(searchString)
                     || c.TelephoneNumber.Mobile.Contains(searchString)
                     || c.TelephoneNumber.Telephone1.Contains(searchString)
                     || c.TelephoneNumber.Telephone2.Contains(searchString)
                     || c.Address.Street.Contains(searchString)
                     || c.Address.PostalCode.Contains(searchString)
                     || c.Address.Details.Contains(searchString)
                     || c.Address.Country.CountryName.Contains(searchString)
                     || c.Address.Region.RegionName.Contains(searchString));
            }
            switch (sortOrder)
            {
                case "firstName_desc":
                    customers = customers.OrderByDescending(c => c.FirstName);
                    break;
                case "lastName_desc":
                    customers = customers.OrderByDescending(c => c.LastName);
                    break;
                case "DateOfBirth":
                    customers = customers.OrderBy(c => c.DateOfBirth);
                    break;
                case "dateOfBirth_desc":
                    customers = customers.OrderByDescending(c => c.DateOfBirth);
                    break;
                case "SubscriptionStart":
                    customers = customers.OrderBy(c => c.SubscriptionStart);
                    break;
                case "subscriptionStart_desc":
                    customers = customers.OrderByDescending(c => c.SubscriptionStart);
                    break;
                case "SubscriptionEnd":
                    customers = customers.OrderBy(c => c.SubscriptionEnd);
                    break;
                case "subscriptionEnd_desc":
                    customers = customers.OrderByDescending(c => c.SubscriptionEnd);
                    break;
                case "countryName_desc":
                    customers = customers.OrderByDescending(c => c.Address.Country.CountryName);
                    break;
                case "regionName_desc":
                    customers = customers.OrderByDescending(c => c.Address.Region.RegionName);
                    break;
                case "street_desc":
                    customers = customers.OrderByDescending(c => c.Address.Street);
                    break;
                default:
                    customers = customers.OrderBy(c => c.LastName);
                    break;
            }

            int pageSize = 6;
            int pageNumber = (page ?? 1);
            return View(customers.ToPagedList(pageNumber, pageSize));
        }


        // Details for Customer, through MyProfile navigation link
        public ActionResult ShowCustomerProfile()
        {
            var userId = User.Identity.GetUserId();

            if (userId == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Customer customer = db.Customers.FirstOrDefault(c => c.AspNetUsersId == userId);

            var address = db.Addresses.FirstOrDefault(a => a.ID == customer.AddressID);
            var city = db.Cities.FirstOrDefault(c => c.ID == address.CityID);
            var region = db.Regions.FirstOrDefault(r => r.ID == address.RegionID);
            var country = db.Countries.FirstOrDefault(c => c.ID == address.CountryID);
            var telephone = db.TelephoneNumbers.FirstOrDefault(t => t.ID == customer.TelephoneNumberID);

            var viewModel = new SingleCustomerAddressTelephoneViewModel()
            {
                Customer = customer,
                Address = customer.Address,
                City = city,
                Region = region,
                Country = country,
                TelephoneNumber = telephone
            };

            if (customer == null)
            {
                return HttpNotFound();
            }
            return View("Details", "_Layout", viewModel);
        }


        // GET: Customers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Customer customer = db.Customers.Find(id);
            var customer = db.Customers.Include(c => c.User).FirstOrDefault(c => c.ID == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,Surname,Birthday")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(customer).State = EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(customer);
        }


        // GET: Customers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Customer customer = db.Customers.Find(id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // POST: Customers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Customer customer = db.Customers.Find(id);
            db.Customers.Remove(customer);
            db.SaveChanges();
            return RedirectToAction("Index");
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
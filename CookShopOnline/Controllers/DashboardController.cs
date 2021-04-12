using CookShopOnline.Models;
using CookShopOnline.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CookShopOnline.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class DashBoardController : Controller
    {
        private readonly string connectionString = @"Data Source=DESKTOP-AAVBPLH\SQLEXPRESS;Initial Catalog= CookShopDB;Integrated Security=True";

        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
            return DashBoard();
        }
        //GET: DashBoard
        public ActionResult DashBoard()
        {
            var listaProductSales = GetProductSales();
            List<string> products = new List<string>();
            List<int> quanities = new List<int>();
            foreach (var item in listaProductSales)
            {
                products.Add(item.ProductName);
                quanities.Add(item.Quanity);
            }
            //var rep = repartitions;
            ViewBag.Products = products;
            ViewBag.Quanities = quanities;

            var listaCustomersPerCity = GetCustomersPerCity();
            List<string> cities = new List<string>();
            List<int> customersPerCity = new List<int>();
            foreach (var item in listaCustomersPerCity)
            {
                cities.Add(item.CityName);
                customersPerCity.Add(item.CustomersPerCity);
            }
            //var rep = repartitions;
            ViewBag.Cities = cities;
            ViewBag.CustomersPerCity = customersPerCity;

            var listaCustomersPerRegion = GetCustomersPerRegion();
            List<string> regions = new List<string>();
            List<int> customersPerRegion = new List<int>();
            foreach (var item in listaCustomersPerRegion)
            {
                regions.Add(item.RegionName);
                customersPerRegion.Add(item.CustomersPerRegion);
            }
            //var rep = repartitions;
            ViewBag.Regions = regions;
            ViewBag.CustomersPerRegion = customersPerRegion;

            return View("DashBoards");
        }
        public List<ProductSales> GetProductSales()
        {
            List<ProductSales> productSales = new List<ProductSales>();
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    connect.Open();
                    string querySql = "Select * from ProductSales";
                    using (SqlCommand cmdAllProducts = new SqlCommand(querySql, connect))
                    {
                        using (SqlDataReader productReader = cmdAllProducts.ExecuteReader())
                        {
                            while (productReader.Read())
                            {
                                ProductSales productSale = new ProductSales()
                                {
                                    ProductName = (string)productReader["ProductName"],
                                    Quanity = (int)productReader["QuanityNew"]
                                };
                                productSales.Add(productSale);
                            }
                        }
                    }
                }
                catch (SqlException e)
                {
                    Console.WriteLine("SQL EXCEPTION", e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception", e.Message);
                }
                return productSales;
            }
        }
        public List<CustomerRegion> GetCustomersPerRegion()
        {
            List<CustomerRegion> customersPerRegion = new List<CustomerRegion>();
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    connect.Open();
                    string querySql = "Select * from CustomerRegion";
                    using (SqlCommand cmdCustomersPerRegion = new SqlCommand(querySql, connect))
                    {
                        using (SqlDataReader customersPerRegionReader = cmdCustomersPerRegion.ExecuteReader())
                        {
                            while (customersPerRegionReader.Read())
                            {
                                CustomerRegion customerPerRegion = new CustomerRegion()
                                {
                                    RegionName = (string)customersPerRegionReader["RegionName"],
                                    CustomersPerRegion = (int)customersPerRegionReader["Perioxes"]//h8ele Nomoi edw dn kanw drop XD
                                };
                                customersPerRegion.Add(customerPerRegion);
                            }
                        }
                    }
                }
                catch (SqlException e)
                {
                    Console.WriteLine("SQL EXCEPTION", e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception", e.Message);
                }
                return customersPerRegion;
            }
        }
        public List<CustomerCity> GetCustomersPerCity()
        {
            List<CustomerCity> customersPerCity = new List<CustomerCity>();
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    connect.Open();
                    string querySql = "Select * from CustomerCity";
                    using (SqlCommand cmdCustomersPerCity = new SqlCommand(querySql, connect))
                    {
                        using (SqlDataReader customersPerCityReader = cmdCustomersPerCity.ExecuteReader())
                        {
                            while (customersPerCityReader.Read())
                            {
                                CustomerCity customerPerCity = new CustomerCity()
                                {
                                    CityName = (string)customersPerCityReader["Name"],
                                    CustomersPerCity = (int)customersPerCityReader["Poleis"]//h8ele Nomoi edw dn kanw drop XD
                                };
                                customersPerCity.Add(customerPerCity);
                            }
                        }
                    }
                }
                catch (SqlException e)
                {
                    Console.WriteLine("SQL EXCEPTION", e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception", e.Message);
                }
                return customersPerCity;
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using CookShopOnline.Enums;
using CookShopOnline.Models;
using CookShopOnline.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using PagedList;

namespace CookShopOnline.Controllers
{
    public class RecipesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        public ViewResult Index(string sortOrder, string searchString, string currentFilter, int? page, string ResipeCategory, string ResipeDifficulty)
        {
            ViewBag.CurrentSort = sortOrder;

            ViewBag.RecipeSortParam = String.IsNullOrEmpty(sortOrder) || sortOrder == "recipe_asc" ? "recipe_desc" : "recipe_asc";
            ViewBag.RecipeSortDiff = String.IsNullOrEmpty(sortOrder) || sortOrder == "recipe_Diff_asc" ? "recipe_Diff_desc" : "recipe_Diff_asc";
            ViewBag.ClearSort = "clear_sort";

            var CategoryList = new List<string>();
            var CategorySelect = from d in db.RecipeCategories
                                 orderby d.Descreption
                                 select d.Descreption;
            CategoryList.AddRange(CategorySelect.Distinct());
            ViewBag.ResipeCategory = new SelectList(CategoryList);


            var DifficultySelect = from d in db.Recipes
                                   orderby d.DifficultyLevel
                                   select d.DifficultyLevel;
            ViewBag.ResipeDifficulty = new SelectList(DifficultySelect.Distinct());

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewBag.CurrentFilter = searchString;

            var recipes = from r in db.Recipes.Include(r => r.RecipeCategory)
                          select r;

            if (!String.IsNullOrEmpty(searchString))
            {
                recipes = recipes.Where(r => r.RecipeName.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "recipe_desc":
                    recipes = recipes.OrderByDescending(r => r.RecipeName);
                    break;
                case "recipe_asc":
                    recipes = recipes.OrderBy(r => r.RecipeName);
                    break;
                case "recipe_Diff_asc":
                    recipes = recipes.OrderBy(r => r.DifficultyLevel);
                    break;
                case "recipe_Diff_desc":
                    recipes = recipes.OrderByDescending(r => r.DifficultyLevel);
                    break;
                case "clear_sort":
                    recipes = recipes.OrderBy(r => r.RecipeName);
                    break;
                default:
                    recipes = recipes.OrderBy(r => r.RecipeName);
                    break;
            }

            if (!string.IsNullOrEmpty(ResipeCategory))
            {
                recipes = recipes.Where(x => x.RecipeCategory.Descreption == ResipeCategory);
            }

            switch (ResipeDifficulty)
            {
                case "Simple":
                    recipes = recipes.Where(x => x.DifficultyLevel == Enums.DifficultyLevel.Simple);
                    break;
                case "Easy":
                    recipes = recipes.Where(x => x.DifficultyLevel == Enums.DifficultyLevel.Easy);
                    break;
                case "Moderate":
                    recipes = recipes.Where(x => x.DifficultyLevel == Enums.DifficultyLevel.Moderate);
                    break;
                case "Hard":
                    recipes = recipes.Where(x => x.DifficultyLevel == Enums.DifficultyLevel.Hard);
                    break;
                case "Extreme":
                    recipes = recipes.Where(x => x.DifficultyLevel == Enums.DifficultyLevel.Extreme);
                    break;
                default:
                    recipes = recipes.OrderBy(r => r.RecipeName);
                    break;
            }


            int pageSize = 6;
            int pageNumber = (page ?? 1);

            //return View(recipes.ToPagedList(pageNumber, pageSize));
            if (User.IsInRole("Administrator"))
            {
                return View("IndexAdmin", recipes.ToPagedList(pageNumber, pageSize));
            }
            else
            {
                return View("Index", recipes.ToPagedList(pageNumber, pageSize));
            }
        }

        // GET: Recipes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var recipe = db.Recipes
                .Include(r => r.RecipeCategory)
                .Include(r => r.RecipeIngredients)
                .FirstOrDefault(r => r.ID == id);

            // Get recipe's product ids
            var recipeProductsID = db.RecipeIngredients.Where(a2 => a2.RecipeID == id).Select(b => b.Ingredient.ProductID).ToList();
            List<Product> products = new List<Product>();
            // Get all products that are stored in the database
            var productsInDb = db.Products.ToList();
            
            foreach (var item in recipeProductsID)
            {
                // In a new list, add from the products in db only those linked with current recipe
                products.Add(productsInDb.Where(a1 => a1.ID == item).FirstOrDefault());
            }
            
            recipe.Products = products;

            if (recipe == null)
            {
                return HttpNotFound();
            }

            // Choose a view, depending on the current user's role
            if (User.IsInRole("Administrator") || User.IsInRole("Premium"))
            {
                return View("DetailsPremium", recipe);
            }
            else
            {
                return View("Details", recipe);
            }
        }

        // GET: Recipes/Create
        public ActionResult Create()
        {
            ViewBag.RecipeCategoryID = new SelectList(db.RecipeCategories, "ID", "Descreption");
            return View();
        }

        // POST: Recipes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,RecipeName,Instructions,ActiveTime,TotalTime,DifficultyLevel,Tips,VideoUrl,ImageUrl,RecipeCategoryID")] Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                db.Recipes.Add(recipe);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.RecipeCategoryID = new SelectList(db.RecipeCategories, "ID", "Descreption", recipe.RecipeCategoryID);
            return View(recipe);
        }

        // GET: Recipes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipe recipe = db.Recipes.Find(id);
            if (recipe == null)
            {
                return HttpNotFound();
            }
            ViewBag.RecipeCategoryID = new SelectList(db.RecipeCategories, "ID", "Descreption", recipe.RecipeCategoryID);
            return View(recipe);
        }

        // POST: Recipes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,RecipeName,Instructions,ActiveTime,TotalTime,DifficultyLevel,Tips,VideoUrl,RecipeCategoryID")] Recipe recipe)
        {
            if (ModelState.IsValid)
            {
                db.Entry(recipe).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.RecipeCategoryID = new SelectList(db.RecipeCategories, "ID", "Descreption", recipe.RecipeCategoryID);
            return View(recipe);
        }

        // GET: Recipes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recipe recipe = db.Recipes.Find(id);
            if (recipe == null)
            {
                return HttpNotFound();
            }
            return View(recipe);
        }

        // POST: Recipes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Recipe recipe = db.Recipes.Find(id);
            db.Recipes.Remove(recipe);
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

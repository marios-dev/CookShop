using CookShopOnline.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;

[assembly: OwinStartupAttribute(typeof(CookShopOnline.Startup))]
namespace CookShopOnline
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolesAndUsers();
            CheckSubscriptions();
            app.MapSignalR();
        }

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void CreateRolesAndUsers()
        {
            ApplicationDbContext db = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));

            // Check if "User" role exists, and if not create it
            if (!roleManager.RoleExists("User"))
            {
                var role = new IdentityRole();
                role.Name = "User";
                roleManager.Create(role);

                // Create an "Admin" user to be assigned the administrator role and privileges
                var user = new ApplicationUser();
                user.UserName = "user@gmail.com";
                user.Email = "user@gmail.com";

                string userPassword = "User123!";

                var checkUser = userManager.Create(user, userPassword);

                // Assign "Administrator" role to "Admin" user
                if (checkUser.Succeeded)
                {
                    var result = userManager.AddToRole(user.Id, "User");
                }
            }

            // Check if "PremiumUser" role exists, and if not create it
            if (!roleManager.RoleExists("Premium"))
            {
                var role = new IdentityRole();
                role.Name = "Premium";
                roleManager.Create(role);

                // Create an "Admin" user to be assigned the administrator role and privileges
                var user = new ApplicationUser();
                user.UserName = "premium@gmail.com";
                user.Email = "premium@gmail.com";

                string userPassword = "Premium123!";

                var checkUser = userManager.Create(user, userPassword);

                // Assign "Administrator" role to "Admin" user
                if (checkUser.Succeeded)
                {
                    var result = userManager.AddToRole(user.Id, "Premium");
                }
            }

            // Check if "Administrator" role exists, and if not create it
            if (!roleManager.RoleExists("Administrator"))
            {
                var role = new IdentityRole();
                role.Name = "Administrator";
                roleManager.Create(role);

                // Create an "Admin" user to be assigned the administrator role and privileges
                var user = new ApplicationUser();
                user.UserName = "admin@gmail.com";
                user.Email = "admin@gmail.com";

                string userPassword = "Admin123!";

                var checkUser = userManager.Create(user, userPassword);

                // Assign "Administrator" role to "Admin" user
                if (checkUser.Succeeded)
                {
                    var result = userManager.AddToRole(user.Id, "Administrator");
                }
            }
        }

        // For every customer with an active subscription, check if the end date has passed
        // since the last time that the Application ran and, if yes, cancel their subscription
        private void CheckSubscriptions()
        {
            ApplicationDbContext db = new ApplicationDbContext();

            foreach (var customer in db.Customers)
            {
                if (customer.SubscriptionState && customer.SubscriptionEnd < DateTime.Now)
                {
                    // Get the customer's corresponding user Id
                    var userId = customer.AspNetUsersId;

                    // Get the User and Premium roles
                    var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(db));
                    var userRole = roleManager.FindByName("User");
                    var premiumRole = roleManager.FindByName("Premium");

                    // Change customer's role from User to Premium
                    var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(db));
                    userManager.RemoveFromRole(userId, premiumRole.Name);
                    userManager.AddToRole(userId, userRole.Name);

                    // Set _subscriptionState field value to false
                    customer.SubscriptionState = false;
                    customer.SubscriptionStart = null;
                    customer.SubscriptionEnd = null;
                }
            }
        }

    }
}

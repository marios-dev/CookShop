namespace CookShopOnline.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Street = c.String(maxLength: 100),
                        PostalCode = c.String(maxLength: 12),
                        Details = c.String(maxLength: 100),
                        RegionID = c.Int(nullable: false),
                        CityID = c.Int(nullable: false),
                        CountryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Cities", t => t.CityID, cascadeDelete: true)
                .ForeignKey("dbo.Countries", t => t.CountryID, cascadeDelete: true)
                .ForeignKey("dbo.Regions", t => t.RegionID, cascadeDelete: true)
                .Index(t => t.RegionID)
                .Index(t => t.CityID)
                .Index(t => t.CountryID);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Region_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Regions", t => t.Region_ID)
                .Index(t => t.Region_ID);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        CountryCode = c.String(maxLength: 5),
                        CountryName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Regions",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RegionName = c.String(maxLength: 50),
                        Country_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Countries", t => t.Country_ID)
                .Index(t => t.Country_ID);
            
            CreateTable(
                "dbo.CartItems",
                c => new
                    {
                        RecordID = c.Int(nullable: false, identity: true),
                        CartID = c.String(),
                        ProductID = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        DateCreated = c.DateTime(nullable: false),
                        LineTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.RecordID)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ProductName = c.String(),
                        Description = c.String(),
                        ImagePath = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 50),
                        LastName = c.String(maxLength: 50),
                        DateOfBirth = c.DateTime(nullable: false),
                        SubscriptionState = c.Boolean(nullable: false),
                        SubscriptionStart = c.DateTime(),
                        SubscriptionEnd = c.DateTime(),
                        AddressID = c.Int(),
                        TelephoneNumberID = c.Int(),
                        AspNetUsersId = c.String(),
                        User_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Addresses", t => t.AddressID)
                .ForeignKey("dbo.TelephoneNumbers", t => t.TelephoneNumberID)
                .ForeignKey("dbo.AspNetUsers", t => t.User_Id)
                .Index(t => t.AddressID)
                .Index(t => t.TelephoneNumberID)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.TelephoneNumbers",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Telephone1 = c.String(maxLength: 20),
                        Telephone2 = c.String(maxLength: 20),
                        Mobile = c.String(maxLength: 20),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.IngredientCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Description = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Ingredients",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        IngredientCategoryID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.IngredientCategories", t => t.IngredientCategoryID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.IngredientCategoryID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.OrderDetails",
                c => new
                    {
                        OrderDetailID = c.Int(nullable: false, identity: true),
                        OrderID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        UnitPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.OrderDetailID)
                .ForeignKey("dbo.Orders", t => t.OrderID, cascadeDelete: true)
                .ForeignKey("dbo.Products", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.OrderID)
                .Index(t => t.ProductID);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderID = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Total = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OrderDate = c.DateTime(nullable: false),
                        IsPaid = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.OrderID);
            
            CreateTable(
                "dbo.RecipeCategories",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Descreption = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Recipes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RecipeName = c.String(),
                        Instructions = c.String(),
                        ActiveTime = c.String(),
                        TotalTime = c.String(),
                        DifficultyLevel = c.Int(nullable: false),
                        Tips = c.String(),
                        VideoUrl = c.String(),
                        ImageUrl = c.String(),
                        RecipeCategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.RecipeCategories", t => t.RecipeCategoryID, cascadeDelete: true)
                .Index(t => t.RecipeCategoryID);
            
            CreateTable(
                "dbo.RecipeIngredients",
                c => new
                    {
                        RecipeID = c.Int(nullable: false),
                        IngredientID = c.Int(nullable: false),
                        Quantity = c.Double(),
                        MeasuringUnit = c.Int(),
                    })
                .PrimaryKey(t => new { t.RecipeID, t.IngredientID })
                .ForeignKey("dbo.Ingredients", t => t.IngredientID, cascadeDelete: true)
                .ForeignKey("dbo.Recipes", t => t.RecipeID, cascadeDelete: true)
                .Index(t => t.RecipeID)
                .Index(t => t.IngredientID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.RecipeIngredients", "RecipeID", "dbo.Recipes");
            DropForeignKey("dbo.RecipeIngredients", "IngredientID", "dbo.Ingredients");
            DropForeignKey("dbo.Recipes", "RecipeCategoryID", "dbo.RecipeCategories");
            DropForeignKey("dbo.OrderDetails", "ProductID", "dbo.Products");
            DropForeignKey("dbo.OrderDetails", "OrderID", "dbo.Orders");
            DropForeignKey("dbo.Ingredients", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Ingredients", "IngredientCategoryID", "dbo.IngredientCategories");
            DropForeignKey("dbo.Customers", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Customers", "TelephoneNumberID", "dbo.TelephoneNumbers");
            DropForeignKey("dbo.Customers", "AddressID", "dbo.Addresses");
            DropForeignKey("dbo.CartItems", "ProductID", "dbo.Products");
            DropForeignKey("dbo.Addresses", "RegionID", "dbo.Regions");
            DropForeignKey("dbo.Addresses", "CountryID", "dbo.Countries");
            DropForeignKey("dbo.Regions", "Country_ID", "dbo.Countries");
            DropForeignKey("dbo.Cities", "Region_ID", "dbo.Regions");
            DropForeignKey("dbo.Addresses", "CityID", "dbo.Cities");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.RecipeIngredients", new[] { "IngredientID" });
            DropIndex("dbo.RecipeIngredients", new[] { "RecipeID" });
            DropIndex("dbo.Recipes", new[] { "RecipeCategoryID" });
            DropIndex("dbo.OrderDetails", new[] { "ProductID" });
            DropIndex("dbo.OrderDetails", new[] { "OrderID" });
            DropIndex("dbo.Ingredients", new[] { "ProductID" });
            DropIndex("dbo.Ingredients", new[] { "IngredientCategoryID" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Customers", new[] { "User_Id" });
            DropIndex("dbo.Customers", new[] { "TelephoneNumberID" });
            DropIndex("dbo.Customers", new[] { "AddressID" });
            DropIndex("dbo.CartItems", new[] { "ProductID" });
            DropIndex("dbo.Regions", new[] { "Country_ID" });
            DropIndex("dbo.Cities", new[] { "Region_ID" });
            DropIndex("dbo.Addresses", new[] { "CountryID" });
            DropIndex("dbo.Addresses", new[] { "CityID" });
            DropIndex("dbo.Addresses", new[] { "RegionID" });
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.RecipeIngredients");
            DropTable("dbo.Recipes");
            DropTable("dbo.RecipeCategories");
            DropTable("dbo.Orders");
            DropTable("dbo.OrderDetails");
            DropTable("dbo.Ingredients");
            DropTable("dbo.IngredientCategories");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.TelephoneNumbers");
            DropTable("dbo.Customers");
            DropTable("dbo.Products");
            DropTable("dbo.CartItems");
            DropTable("dbo.Regions");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.Addresses");
        }
    }
}

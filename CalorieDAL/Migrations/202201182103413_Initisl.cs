namespace CalorieDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initisl : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Foods",
                c => new
                    {
                        FoodID = c.Int(nullable: false, identity: true),
                        FoodName = c.String(nullable: false),
                        Calorie = c.Double(nullable: false),
                        Carbohydrate = c.Double(nullable: false),
                        Protein = c.Double(nullable: false),
                        Fat = c.Double(nullable: false),
                        Portion = c.String(nullable: false),
                        Amount = c.Double(nullable: false),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FoodID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
            CreateTable(
                "dbo.Operations",
                c => new
                    {
                        OperationID = c.Int(nullable: false, identity: true),
                        Amount = c.Double(nullable: false),
                        Date = c.DateTime(nullable: false),
                        UserID = c.Int(nullable: false),
                        FoodID = c.Int(nullable: false),
                        MealID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.OperationID)
                .ForeignKey("dbo.Meals", t => t.MealID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .ForeignKey("dbo.Foods", t => t.FoodID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.FoodID)
                .Index(t => t.MealID);
            
            CreateTable(
                "dbo.Meals",
                c => new
                    {
                        MealID = c.Int(nullable: false, identity: true),
                        MealName = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MealID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Surname = c.String(nullable: false, maxLength: 50),
                        Gender = c.Boolean(nullable: false),
                        Height = c.Double(nullable: false),
                        Weight = c.Double(nullable: false),
                        Age = c.Int(nullable: false),
                        SportBackground = c.Int(nullable: false),
                        Usermail = c.String(nullable: false, maxLength: 50),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UserID)
                .Index(t => t.Usermail, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Foods", "CategoryID", "dbo.Categories");
            DropForeignKey("dbo.Operations", "FoodID", "dbo.Foods");
            DropForeignKey("dbo.Operations", "UserID", "dbo.Users");
            DropForeignKey("dbo.Operations", "MealID", "dbo.Meals");
            DropIndex("dbo.Users", new[] { "Usermail" });
            DropIndex("dbo.Operations", new[] { "MealID" });
            DropIndex("dbo.Operations", new[] { "FoodID" });
            DropIndex("dbo.Operations", new[] { "UserID" });
            DropIndex("dbo.Foods", new[] { "CategoryID" });
            DropTable("dbo.Users");
            DropTable("dbo.Meals");
            DropTable("dbo.Operations");
            DropTable("dbo.Foods");
            DropTable("dbo.Categories");
        }
    }
}

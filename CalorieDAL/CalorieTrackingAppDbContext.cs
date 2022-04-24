using CalorieMODEL.Entities;
using CalorieDAL.EntityConfiguration;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieDAL
{
    public class CalorieTrackingAppDbContext : DbContext
    {
        public CalorieTrackingAppDbContext() : base("Server =LAPTOP-GP2BH4V1\\SQLEXPRESS; Database = CalorieTrackingDb ; Trusted_Connection=True;")
        {
           
        }

        //DbSet
        public DbSet<Category> Categorie { get; set; }
        public DbSet<Food> Food { get; set; }
        public DbSet<Meal> Meal { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Operation> Operation { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserConfiguration());
            modelBuilder.Configurations.Add(new OperationConfiguration());
            modelBuilder.Configurations.Add(new MealConfiguration());
            modelBuilder.Configurations.Add(new FoodConfiguration());
            modelBuilder.Configurations.Add(new CategoryConfiguration());
        }
    }
}

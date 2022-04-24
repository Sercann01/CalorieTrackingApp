using CalorieMODEL.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalorieDAL.EntityConfiguration
{
    class OperationConfiguration : EntityTypeConfiguration<Operation>
    {
        public OperationConfiguration()
        {

            Property(a => a.OperationID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            //HasKey(a => new { a.UserID, a.MealID, a.FoodID });

            //HasRequired(a => a.User)
            //     .WithMany(a => a.Operations)
            //     .HasForeignKey(a => a.UserID);

            //HasRequired(a => a.Food)
            //    .WithMany(a => a.Operations)
            //    .HasForeignKey(a => a.FoodID);

            //HasRequired(a => a.Meal)
            //    .WithMany(a => a.Operations)
            //    .HasForeignKey(a => a.MealID);



        }
    }
}

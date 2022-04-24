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
    class MealConfiguration : EntityTypeConfiguration<Meal>
    {
        public MealConfiguration()
        {
            Property(a => a.MealID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.MealName).IsRequired();


            HasMany(a => a.Operations)
                .WithRequired(a => a.Meal)
                .HasForeignKey(a => a.MealID);
        }
    }
}

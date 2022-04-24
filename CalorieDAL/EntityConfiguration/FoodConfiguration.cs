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
    class FoodConfiguration : EntityTypeConfiguration<Food>
    {
        public FoodConfiguration()
        {
            Property(a => a.FoodID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.FoodName).IsRequired();
            Property(a => a.Calorie).IsRequired();
            Property(a => a.Carbohydrate).IsRequired();
            Property(a => a.Protein).IsRequired();
            Property(a => a.Fat).IsRequired();
            Property(a => a.Portion).IsRequired();
            Property(a => a.Amount).IsRequired();


            HasMany(a => a.Operations)
                .WithRequired(a => a.Food)
                .HasForeignKey(a => a.FoodID);
        }
    }
}

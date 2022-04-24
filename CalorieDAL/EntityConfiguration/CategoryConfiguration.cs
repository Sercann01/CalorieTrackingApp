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
    class CategoryConfiguration : EntityTypeConfiguration<Category>
    {
        public CategoryConfiguration()
        {
            Property(a => a.CategoryID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.CategoryName).IsRequired();


            HasMany(a => a.Foods)
                .WithRequired(a => a.CategoryID)
                .HasForeignKey(a => a.CategoryID);
        }
    }
}

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
    class UserConfiguration : EntityTypeConfiguration<User>
    {
        public UserConfiguration()
        {
            Property(a => a.UserID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.Name).IsRequired().HasMaxLength(50);

            Property(a => a.Surname).IsRequired().HasMaxLength(50);

            Property(a => a.Usermail).IsRequired().HasMaxLength(50);
            HasIndex(a => a.Usermail).IsUnique();

            HasMany(a => a.Operations)
                .WithRequired(a => a.User)
                .HasForeignKey(a => a.UserID);




        }
    }
}

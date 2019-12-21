using ETicaret_Entity.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret_DAL.Mappings
{
    public class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            HasKey(x => x.UserId);
            Property(x => x.Email).IsRequired().HasMaxLength(35).HasColumnType("nvarchar");
            Property(x => x.Password).IsRequired().HasMaxLength(20).HasColumnType("nvarchar");
            Property(x => x.UserName).IsOptional().HasMaxLength(30).HasColumnType("nvarchar");
            Property(x => x.LastName).IsOptional().HasMaxLength(30).HasColumnType("nvarchar");
            Property(x => x.CardId).IsRequired();
            Property(x => x.FavoriteListId).IsRequired();

            HasRequired(x => x.Card).WithRequiredPrincipal(c => c.User);

            HasRequired(x => x.FavoriteList).WithRequiredPrincipal(c => c.User);
        }

    }
}
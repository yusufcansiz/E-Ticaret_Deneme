using ETicaret_Entity.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret_DAL.Mappings
{
    public class FavoriteListMapping : EntityTypeConfiguration<FavoriteList>
    {
        public FavoriteListMapping()
        {
            HasKey(x => x.FavoriteListId);

            HasRequired(x => x.User).WithRequiredPrincipal(u => u.FavoriteList);

            HasMany(x => x.Products)
                .WithMany(p => p.FavoriteList)
                .Map(m =>
                {
                    m.ToTable("Product_FavoriteList");
                    m.MapLeftKey("FavoriteListId");
                    m.MapRightKey("ProductId");
                });
        }
    }
}

using ETicaret_Entity.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret_DAL.Mappings
{
    public class ProductMapping : EntityTypeConfiguration<Product>
    {
        public ProductMapping()
        {
            HasKey(x => x.ProductId);
            Property(x => x.ProductName).IsRequired().HasMaxLength(35).HasColumnType("nvarchar");
            Property(x => x.ProductDescription).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ProductProperty).IsOptional().HasColumnType("nvarchar").HasMaxLength(50);
            Property(x => x.ProductPrice).IsRequired().HasColumnType("money");
            Property(x => x.ProductStock).IsOptional();
            Property(x => x.isActive).IsRequired();

        }
    }
}

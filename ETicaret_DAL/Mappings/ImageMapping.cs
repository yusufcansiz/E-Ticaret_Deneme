using ETicaret_Entity.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ETicaret_DAL.Mappings
{
    public class ImageMapping : EntityTypeConfiguration<Image>
    {
        public ImageMapping()
        {
            HasKey(x => x.ImageId);
            Property(x => x.ImagePath).HasColumnType("nvarchar").HasMaxLength(500);
            Property(x => x.ProductId).IsOptional();
            Property(x => x.AdvertisementId).IsOptional();

            HasRequired(x => x.Advertisement).WithMany(a => a.Images).HasForeignKey(x => x.AdvertisementId);

            HasRequired(x => x.Products).WithMany(p => p.Images).HasForeignKey(x => x.ProductId);
        }
    }
}

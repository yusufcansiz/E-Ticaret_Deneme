using ETicaret_Entity.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret_DAL.Mappings
{
    public class CategoryMapping : EntityTypeConfiguration<Category>
    {
        public CategoryMapping()
        {
            HasKey(x => x.CategoryId);
            Property(x => x.CategoryName).HasMaxLength(50).IsRequired().HasColumnType("nvarchar");
            Property(x => x.CategoryDescription).HasMaxLength(100).IsRequired().HasColumnType("nvarchar");
            Property(x => x.MainCategoryId).IsOptional();
            Property(x => x.IsActive).IsRequired();

            //HasRequired(x => x.MainCategory).WithMany(u => u.CategoryId).HasForeignKey(x => x.MainCategoryId);

        }
    }
}

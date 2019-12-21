using ETicaret_Entity.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret_DAL.Mappings
{
    public class CommentMapping : EntityTypeConfiguration<Comment>
    {
        public CommentMapping()
        {
            HasKey(x => x.CommentId);
            Property(x => x.CommentDescription).IsRequired().HasMaxLength(500).HasColumnType("nvarchar");
            Property(x => x.CommentPoint).IsRequired();

            HasRequired(x => x.User).WithMany(u => u.Comment).HasForeignKey(x => x.UserId);

            HasRequired(x => x.Product).WithMany(p => p.Comments).HasForeignKey(x => x.ProductId);
        }
    }
}

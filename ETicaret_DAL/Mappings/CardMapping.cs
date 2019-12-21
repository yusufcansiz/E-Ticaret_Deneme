using ETicaret_Entity.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret_DAL.Mappings
{
    public class CardMapping : EntityTypeConfiguration<Card>
    {
        public CardMapping()
        {
            HasKey(x => x.CardId);
            Property(x => x.Quantity).IsRequired().HasColumnType("money");

            HasRequired(x => x.Payment).WithRequiredPrincipal(u => u.Card);

            HasMany(x => x.Products)
                .WithMany(k => k.Cards)
                .Map(m =>
                {
                    m.ToTable("Card_Product");
                    m.MapLeftKey("CardId");
                    m.MapRightKey("ProductId");
                });
        }
    }
}

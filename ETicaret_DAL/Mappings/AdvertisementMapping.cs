using ETicaret_Entity.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret_DAL.Mappings
{
    public class AdvertisementMapping : EntityTypeConfiguration<Advertisement>
    {
        public AdvertisementMapping()
        {
            HasKey(x => x.AdvertisementId);
            Property(x => x.AdvertisementLink).IsOptional().HasMaxLength(250);
        }
    }
}

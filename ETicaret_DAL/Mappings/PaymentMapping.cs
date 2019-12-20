using ETicaret_Entity.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret_DAL.Mappings
{
    public class PaymentMapping : EntityTypeConfiguration<Payment>
    {
        public PaymentMapping()
        {
            HasKey(x => x.PaymentId);
            
        }
    }
}

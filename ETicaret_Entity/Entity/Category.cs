using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret_Entity.Entity
{
    public class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
        
        public string CategoryDescription { get; set; }

        public bool IsActive { get; set; }


        public int MainCategoryId { get; set; }

        public virtual Category MainCategory { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}

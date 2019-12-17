using System.Collections.Generic;

namespace ETicaret_Entity.Entity
{
    public class Product
    {
        public Product()
        {
            Comments = new HashSet<Comment>();

            Images = new HashSet<Image>();
        }
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public string ProductProperty { get; set; }

        public decimal ProductPrice { get; set; }


        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Image> Images { get; set; }
    }
}

///aciklama
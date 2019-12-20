using System.Collections.Generic;

namespace ETicaret_Entity.Entity
{
    public class Card
    {
        public Card()
        {
            Products = new HashSet<Product>();
        }
        public int CardId { get; set; }

        public decimal Quantity { get; set; }


        public int UserId { get; set; }

        public virtual User User{ get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
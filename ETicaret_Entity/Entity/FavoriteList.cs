using System.Collections.Generic;

namespace ETicaret_Entity.Entity
{
    public class FavoriteList
    {
        public int FavoriteListId { get; set; }


        public int UserId { get; set; }

        public virtual User User { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
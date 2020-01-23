using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret_Entity.Entity
{
    public class User
    {
        public User()
        {
            Comment = new HashSet<Comment>();

            Payment = new HashSet<Payment>();
        }
        public int UserId { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsActive { get; set; }

        public bool IsAdmin { get; set; }



        public int CardId { get; set; }

        public virtual Card Card { get; set; }

        public int FavoriteListId { get; set; }

        public virtual FavoriteList FavoriteList { get; set; }

        public virtual ICollection<Comment> Comment { get; set; }

        public virtual ICollection<Payment> Payment{ get; set; }


    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret_Entity.Entity
{
    public class User
    {
        public int UserId { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string UserName { get; set; }

        public string LastName { get; set; }

        public bool IsActive { get; set; }

        public bool IsAdmin { get; set; }



        public int CardId { get; set; }

        public virtual Card Cards { get; set; }

        public int FavoriteListId { get; set; }

        public virtual FavoriteList FavoriteList { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        
    }
}


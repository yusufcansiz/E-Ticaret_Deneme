namespace ETicaret_Entity.Entity
{
    public class Comment
    {
        public int CommentId { get; set; }

        public string CommentDescription { get; set; }

        public int CommentPoint { get; set; }


        public int UserId { get; set; }

        public virtual User User { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
namespace ETicaret_Entity.Entity
{
    public class Comment
    {
        public int CommentId { get; set; }

        public string CommentDescription { get; set; }

        public int Point { get; set; }



        public int ProductId { get; set; }

        public virtual Product Products { get; set; }
    }
}
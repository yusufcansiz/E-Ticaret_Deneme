namespace ETicaret_Entity.Entity
{
    public class Image
    {
        public int ImageId { get; set; }

        public string ImagePath { get; set; }

        
        
        
        public int ProductId { get; set; }

        public virtual Product Products { get; set; }

        
        public virtual int AdvertisementId { get; set; }

        public virtual Advertisement Advertisement{ get; set; }
    }
}
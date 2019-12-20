using System.Collections.Generic;

namespace ETicaret_Entity.Entity
{
    public class Advertisement
    {
        public Advertisement()
        {
            Images = new HashSet<Image>();
        }
        public int AdvertisementId { get; set; }

        public string AdvertisementLink { get; set; }


        public virtual ICollection<Image> Images { get; set; }
    }
}
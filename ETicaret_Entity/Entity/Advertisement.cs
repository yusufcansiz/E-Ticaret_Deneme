using System.Collections.Generic;

namespace ETicaret_Entity.Entity
{
    public class Advertisement
    {
        public int AdvertisementId { get; set; }

        public string AdvertisementLink { get; set; }


        public virtual ICollection<Image> Images { get; set; }
    }
}
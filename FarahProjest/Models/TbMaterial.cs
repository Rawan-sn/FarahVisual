using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbMaterial
    {
        public TbMaterial()
        {
            TbDonations = new HashSet<TbDonation>();
            TbMaterialAidbaskets = new HashSet<TbMaterialAidbasket>();
            TbOffers = new HashSet<TbOffer>();
        }

        public int ClusterId { get; set; }
        public Guid MaterialId { get; set; }
        public string MaterialName { get; set; }
        public bool? IsVisible { get; set; }
        public string MaterialStatus { get; set; }
        public Guid? CategoryId { get; set; }

        public virtual TbCategory Category { get; set; }
        public virtual ICollection<TbDonation> TbDonations { get; set; }
        public virtual ICollection<TbMaterialAidbasket> TbMaterialAidbaskets { get; set; }
        public virtual ICollection<TbOffer> TbOffers { get; set; }
    }
}

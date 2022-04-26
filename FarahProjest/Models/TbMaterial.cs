using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbMaterial
    {
        public TbMaterial()
        {
            TbOffers = new HashSet<TbOffer>();
        }

        public int ClusterId { get; set; }
        public Guid MaterialId { get; set; }
        public Guid? CategoryId { get; set; }
        public string MaterialName { get; set; }
        public bool? IsVisible { get; set; }
        public string MaterialStatus { get; set; }

        public virtual ICollection<TbOffer> TbOffers { get; set; }
    }
}

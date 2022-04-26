using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbSponser
    {
        public TbSponser()
        {
            TbDemandOrders = new HashSet<TbDemandOrder>();
            TbSponserOrders = new HashSet<TbSponserOrder>();
        }

        public int ClusterId { get; set; }
        public Guid SponserId { get; set; }
        public Guid? UserId { get; set; }
        public string SponserName { get; set; }
        public string SponserAddress { get; set; }
        public string Gender { get; set; }
        public string Telephone { get; set; }
        public string Phone { get; set; }
        public int? Age { get; set; }
        public bool? IsVisible { get; set; }

        public virtual ICollection<TbDemandOrder> TbDemandOrders { get; set; }
        public virtual ICollection<TbSponserOrder> TbSponserOrders { get; set; }
    }
}

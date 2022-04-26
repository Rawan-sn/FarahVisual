using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbBenefactor
    {
        public TbBenefactor()
        {
            TbDemandOrders = new HashSet<TbDemandOrder>();
        }

        public int ClusterId { get; set; }
        public Guid BenefactorId { get; set; }
        public Guid? UserId { get; set; }
        public string BenefactorName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public bool? IsVisible { get; set; }
        public string Gender { get; set; }
        public int? Age { get; set; }
        public string Occupation { get; set; }

        public virtual ICollection<TbDemandOrder> TbDemandOrders { get; set; }
    }
}

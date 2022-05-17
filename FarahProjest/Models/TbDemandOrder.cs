using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbDemandOrder
    {
        public int ClusterId { get; set; }
        public Guid DemandOrderId { get; set; }
        public Guid? FamilyBeneficiaryId { get; set; }
        public Guid? SponserId { get; set; }
        public Guid? BenefactorId { get; set; }
        public DateTime? DemandOrderDate { get; set; }
        public string StatusOrder { get; set; }
        public DateTime? AcceptOrderDate { get; set; }
        public DateTime? RejectOrderDate { get; set; }
        public string DescriptionDemand { get; set; }
        public Guid? ReliabilityPhoto { get; set; }
        public bool? IsVisible { get; set; }
        public int? NumberOrder { get; set; }

        public virtual TbBenefactor Benefactor { get; set; }
        public virtual TbFamilyBeneficiary FamilyBeneficiary { get; set; }
        public virtual TbSponser Sponser { get; set; }
    }
}

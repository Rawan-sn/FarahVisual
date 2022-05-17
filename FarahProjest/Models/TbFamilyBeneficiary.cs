using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbFamilyBeneficiary
    {
        public TbFamilyBeneficiary()
        {
            TbDemandOrders = new HashSet<TbDemandOrder>();
            TbSponserOrders = new HashSet<TbSponserOrder>();
        }

        public int ClusterId { get; set; }
        public Guid FamilyBeneficiaryId { get; set; }
        public Guid UserId { get; set; }
        public string NiceName { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string FamilyStatusId { get; set; }
        public string MonthlyIncoming { get; set; }
        public string FamilyIncoming { get; set; }
        public string OtherIncoming { get; set; }
        public string DetectionReport { get; set; }
        public DateTime? DetectionDate { get; set; }
        public string OrderSenderName { get; set; }
        public string OrderSenderAdj { get; set; }
        public bool? IsVisible { get; set; }

        public virtual ICollection<TbDemandOrder> TbDemandOrders { get; set; }
        public virtual ICollection<TbSponserOrder> TbSponserOrders { get; set; }
    }
}

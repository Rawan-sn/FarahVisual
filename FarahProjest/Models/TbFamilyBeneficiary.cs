using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbFamilyBeneficiary
    {
        public TbFamilyBeneficiary()
        {
            TbAidBaskets = new HashSet<TbAidBasket>();
            TbDemandOrders = new HashSet<TbDemandOrder>();
            TbFamilyAssets = new HashSet<TbFamilyAsset>();
            TbFamilyMembers = new HashSet<TbFamilyMember>();
            TbMonthlySalaries = new HashSet<TbMonthlySalary>();
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

        public virtual ICollection<TbAidBasket> TbAidBaskets { get; set; }
        public virtual ICollection<TbDemandOrder> TbDemandOrders { get; set; }
        public virtual ICollection<TbFamilyAsset> TbFamilyAssets { get; set; }
        public virtual ICollection<TbFamilyMember> TbFamilyMembers { get; set; }
        public virtual ICollection<TbMonthlySalary> TbMonthlySalaries { get; set; }
        public virtual ICollection<TbSponserOrder> TbSponserOrders { get; set; }
    }
}

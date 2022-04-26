using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbDonation
    {
        public int ClusterId { get; set; }
        public Guid DonationId { get; set; }
        public Guid? BenefactorId { get; set; }
        public Guid? MaterialId { get; set; }
        public int? Amount { get; set; }
        public string TypeDonation { get; set; }
        public string StatusDonation { get; set; }
        public bool? IsVisible { get; set; }
        public int? DonationValue { get; set; }
        public int? DonationNumber { get; set; }
        public DateTime? RecievedDate { get; set; }
    }
}

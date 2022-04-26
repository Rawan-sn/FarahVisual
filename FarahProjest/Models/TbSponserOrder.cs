using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbSponserOrder
    {
        public TbSponserOrder()
        {
            TbOffers = new HashSet<TbOffer>();
            TbUpdatingSponsers = new HashSet<TbUpdatingSponser>();
        }

        public int ClusterId { get; set; }
        public Guid OrderId { get; set; }
        public int? NumberOrder { get; set; }
        public Guid SponserId { get; set; }
        public Guid FamilyBeneficiaryId { get; set; }
        public string StatusOrder { get; set; }
        public string SponserSalary { get; set; }
        public string SponserShipPeriod { get; set; }
        public DateTime? StartingDate { get; set; }
        public DateTime? EndingDate { get; set; }
        public DateTime? SponsorAcceptDate { get; set; }
        public DateTime? SponsorRejectDate { get; set; }
        public bool? IsVisible { get; set; }

        public virtual TbFamilyBeneficiary FamilyBeneficiary { get; set; }
        public virtual TbSponser Sponser { get; set; }
        public virtual ICollection<TbOffer> TbOffers { get; set; }
        public virtual ICollection<TbUpdatingSponser> TbUpdatingSponsers { get; set; }
    }
}

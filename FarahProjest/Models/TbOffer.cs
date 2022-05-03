using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbOffer
    {
        public int ClusterId { get; set; }
        public Guid OfferId { get; set; }
        public Guid SponserOrderId { get; set; }
        public DateTime? OfferDate { get; set; }
        public string TypeOffer { get; set; }
        public Guid? MaterialId { get; set; }
        public int? Amount { get; set; }
        public string Description { get; set; }
        public string OfferStatus { get; set; }
        public DateTime? OfferAcceptDate { get; set; }
        public DateTime? OfferRejectDate { get; set; }
        public bool? IsVisible { get; set; }

        public virtual TbMaterial Material { get; set; }
        public virtual TbSponserOrder SponserOrder { get; set; }
    }
}

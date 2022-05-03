using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbUpdatingSponser
    {
        public int ClusterId { get; set; }
        public Guid UpdatingSponserId { get; set; }
        public Guid? SponserOrderId { get; set; }
        public int? UpdatingNumber { get; set; }
        public DateTime? StartingDate { get; set; }
        public DateTime? EndingDate { get; set; }
        public Guid? Signature { get; set; }
        public bool? IsVisible { get; set; }

        public virtual TbSponserOrder SponserOrder { get; set; }
    }
}

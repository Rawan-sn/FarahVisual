using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbFamilyAsset
    {
        public int ClusterId { get; set; }
        public Guid FamilyAssetId { get; set; }
        public Guid? FamilyBeneficiaryId { get; set; }
        public Guid? AssetId { get; set; }
        public int? CountAsset { get; set; }
        public string StatusAsset { get; set; }
        public bool? IsVisible { get; set; }
    }
}

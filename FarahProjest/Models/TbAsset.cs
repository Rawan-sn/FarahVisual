using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbAsset
    {
        public TbAsset()
        {
            TbFamilyAssets = new HashSet<TbFamilyAsset>();
        }

        public int ClusterId { get; set; }
        public Guid AssetId { get; set; }
        public string AssetName { get; set; }
        public int? AssetPriority { get; set; }
        public bool? IsVisible { get; set; }

        public virtual ICollection<TbFamilyAsset> TbFamilyAssets { get; set; }
    }
}

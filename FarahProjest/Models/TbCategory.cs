using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbCategory
    {
        public TbCategory()
        {
            TbMaterials = new HashSet<TbMaterial>();
        }

        public int ClusterId { get; set; }
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool? IsVisible { get; set; }

        public virtual ICollection<TbMaterial> TbMaterials { get; set; }
    }
}

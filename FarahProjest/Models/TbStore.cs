using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbStore
    {
        public int ClusterId { get; set; }
        public Guid StoreId { get; set; }
        public Guid? MaterialId { get; set; }
        public int? Quantity { get; set; }
        public bool? IsVisible { get; set; }
    }
}

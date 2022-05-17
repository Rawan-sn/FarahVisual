using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbMaterialAidbasket
    {
        public int ClusterId { get; set; }
        public Guid MaterialAidbasketId { get; set; }
        public Guid? AidBasketId { get; set; }
        public Guid? MaterialId { get; set; }
        public int? Count { get; set; }
        public bool? IsVisible { get; set; }

        public virtual TbAidBasket AidBasket { get; set; }
        public virtual TbMaterial Material { get; set; }
    }
}

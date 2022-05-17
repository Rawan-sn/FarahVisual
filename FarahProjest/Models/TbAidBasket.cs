using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbAidBasket
    {
        public TbAidBasket()
        {
            TbMaterialAidbaskets = new HashSet<TbMaterialAidbasket>();
        }

        public int ClusterId { get; set; }
        public Guid AidBasketId { get; set; }
        public Guid? FamilyBeneficiaryId { get; set; }
        public bool? IsVisible { get; set; }
        public int? BasketNumber { get; set; }
        public DateTime? BasketDate { get; set; }
        public DateTime? BasketRecievedDate { get; set; }
        public string RecieverName { get; set; }
        public string StatusBasket { get; set; }
        public Guid? SignaturePic { get; set; }

        public virtual ICollection<TbMaterialAidbasket> TbMaterialAidbaskets { get; set; }
    }
}

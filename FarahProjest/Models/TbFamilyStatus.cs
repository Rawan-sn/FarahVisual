using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbFamilyStatus
    {
        public int ClusterId { get; set; }
        public Guid FamilyStatusId { get; set; }
        public string StatusName { get; set; }
        public bool? IsVisible { get; set; }
    }
}

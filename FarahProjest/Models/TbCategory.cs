using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbCategory
    {
        public int ClusterId { get; set; }
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool? IsVisible { get; set; }
    }
}

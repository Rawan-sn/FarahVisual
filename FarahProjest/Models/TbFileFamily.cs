using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbFileFamily
    {
        public int ClusterId { get; set; }
        public Guid FileFamilyId { get; set; }
        public string FileName { get; set; }
        public string FileDescription { get; set; }
        public Guid? Pic { get; set; }
        public bool? IsVisible { get; set; }
    }
}

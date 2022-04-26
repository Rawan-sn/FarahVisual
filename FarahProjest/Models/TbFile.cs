using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbFile
    {
        public int ClusterId { get; set; }
        public Guid FileId { get; set; }
        public short FileExtensionId { get; set; }
        public DateTime LastUpdate { get; set; }
    }
}

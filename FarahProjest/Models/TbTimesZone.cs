using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbTimesZone
    {
        public int ClusterId { get; set; }
        public Guid TimeZoneId { get; set; }
        public string TimeZoneName { get; set; }
        public double? TimeZone { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbdimProvince
    {
        public int ClusterId { get; set; }
        public Guid ProvinceId { get; set; }
        public string ProvinceNameEn { get; set; }
        public string ProvinceNameAr { get; set; }
    }
}

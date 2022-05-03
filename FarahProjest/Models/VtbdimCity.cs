using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class VtbdimCity
    {
        public string CountryNameEn { get; set; }
        public string CountryNameAr { get; set; }
        public int ClusterId { get; set; }
        public Guid CityId { get; set; }
        public string CityNameEn { get; set; }
        public string CityNameAr { get; set; }
        public string CityAscii { get; set; }
        public string CityCode { get; set; }
        public string GeogText { get; set; }
        public byte? GeogZoom { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public string Pop { get; set; }
        public Guid? ProvinceId { get; set; }
        public Guid CountryId { get; set; }
        public string ProvinceNameAr { get; set; }
        public string ProvinceNameEn { get; set; }
    }
}

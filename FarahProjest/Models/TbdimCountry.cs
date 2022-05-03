using System;
using System.Collections.Generic;
using NetTopologySuite.Geometries;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbdimCountry
    {
        public byte ClusterId { get; set; }
        public Guid CountryId { get; set; }
        public string CountryNameEn { get; set; }
        public string CountryNameAr { get; set; }
        public string Continent { get; set; }
        public string CountryId1 { get; set; }
        public string CountriesNameCode { get; set; }
        public string CountryCode { get; set; }
        public string Iso3 { get; set; }
        public Geometry GeogInfo { get; set; }
        public string GeogText { get; set; }
        public byte? GeogZoom { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public string Pop { get; set; }
    }
}

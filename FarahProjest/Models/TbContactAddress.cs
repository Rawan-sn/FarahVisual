using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbContactAddress
    {
        public int ClusterId { get; set; }
        public Guid ContactId { get; set; }
        public Guid? CountryId { get; set; }
        public Guid? CityId { get; set; }
        public string AddressDetail { get; set; }
        public string GeogText { get; set; }
        public byte? GeogZoom { get; set; }
    }
}

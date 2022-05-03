using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class VwContact
    {
        public Guid ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsEmployee { get; set; }
        public bool IsUser { get; set; }
        public Guid? UserId { get; set; }
        public bool? IsAdmin { get; set; }
        public bool? IsMember { get; set; }
        public bool? IsClient { get; set; }
        public Guid? CountryId { get; set; }
        public Guid? CityId { get; set; }
        public Guid? FileId { get; set; }
        public string Extension { get; set; }
        public string GeogText { get; set; }
        public byte? GeogZoom { get; set; }
        public int ClusterId { get; set; }
    }
}

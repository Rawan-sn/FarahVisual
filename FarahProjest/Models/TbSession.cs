using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbSession
    {
        public int ClusterId { get; set; }
        public Guid SessionId { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastDate { get; set; }
        public string TokenCode { get; set; }
        public int? DeviceType { get; set; }
        public string DeviceCode { get; set; }
        public string VersionNumber { get; set; }
        public bool IsLocked { get; set; }
        public string FirebaseToken { get; set; }
    }
}

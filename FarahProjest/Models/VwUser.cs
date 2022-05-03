using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class VwUser
    {
        public string MobileAlias { get; set; }
        public bool IsAnonymous { get; set; }
        public bool? IsAdmin { get; set; }
        public DateTime LastActivityDate { get; set; }
        public bool IsMember { get; set; }
        public bool IsClient { get; set; }
        public Guid? TimeZoneId { get; set; }
        public Guid ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsUser { get; set; }
        public Guid? EngineerId { get; set; }
        public bool IsVisible { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid FileId { get; set; }
        public string Extension { get; set; }
        public bool IsEmployee { get; set; }
        public string UserName { get; set; }
        public Guid UserId { get; set; }
    }
}

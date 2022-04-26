using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbUser
    {
        public int ClusterId { get; set; }
        public Guid UserId { get; set; }
        public Guid? ContactId { get; set; }
        public string UserName { get; set; }
        public string MobileAlias { get; set; }
        public bool IsAnonymous { get; set; }
        public bool? IsAdmin { get; set; }
        public DateTime LastActivityDate { get; set; }
        public bool IsMember { get; set; }
        public bool IsClient { get; set; }
        public Guid? TimeZoneId { get; set; }
    }
}

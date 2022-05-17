using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbAttendceActivity
    {
        public int ClusterId { get; set; }
        public Guid AttendceActivityId { get; set; }
        public Guid? MemberActivityId { get; set; }
        public Guid? VolunteerActivityId { get; set; }
        public Guid? TimeActivityId { get; set; }
        public string StatusAttendce { get; set; }
        public bool? IsVisible { get; set; }

        public virtual TbMemberActivity MemberActivity { get; set; }
        public virtual TbTimeActivity TimeActivity { get; set; }
        public virtual TbVolunteerActivity VolunteerActivity { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbMemberActivity
    {
        public TbMemberActivity()
        {
            TbAttendceActivities = new HashSet<TbAttendceActivity>();
        }

        public int ClusterId { get; set; }
        public Guid MemberActivityId { get; set; }
        public Guid FamilyMemberId { get; set; }
        public Guid ActivityId { get; set; }
        public string Result { get; set; }
        public bool? IsVisible { get; set; }
        public string Status { get; set; }
        public string StatusResult { get; set; }

        public virtual TbActivity Activity { get; set; }
        public virtual TbFamilyMember FamilyMember { get; set; }
        public virtual ICollection<TbAttendceActivity> TbAttendceActivities { get; set; }
    }
}

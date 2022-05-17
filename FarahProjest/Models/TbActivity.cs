using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbActivity
    {
        public TbActivity()
        {
            TbMemberActivities = new HashSet<TbMemberActivity>();
            TbTimeActivities = new HashSet<TbTimeActivity>();
            TbVolunteerActivities = new HashSet<TbVolunteerActivity>();
        }

        public int ClusterId { get; set; }
        public Guid ActivityId { get; set; }
        public string NameActivity { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string TargetActivity { get; set; }
        public string Place { get; set; }
        public int? MaxMember { get; set; }
        public bool? IsVisible { get; set; }
        public string Status { get; set; }

        public virtual ICollection<TbMemberActivity> TbMemberActivities { get; set; }
        public virtual ICollection<TbTimeActivity> TbTimeActivities { get; set; }
        public virtual ICollection<TbVolunteerActivity> TbVolunteerActivities { get; set; }
    }
}

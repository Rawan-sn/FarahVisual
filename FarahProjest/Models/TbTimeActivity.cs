using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbTimeActivity
    {
        public TbTimeActivity()
        {
            TbAttendceActivities = new HashSet<TbAttendceActivity>();
        }

        public int ClusterId { get; set; }
        public Guid TimeActivityId { get; set; }
        public DateTime? DateActivity { get; set; }
        public string TimeActivity { get; set; }
        public Guid? ActivityId { get; set; }
        public bool? IsVisible { get; set; }

        public virtual TbActivity Activity { get; set; }
        public virtual ICollection<TbAttendceActivity> TbAttendceActivities { get; set; }
    }
}

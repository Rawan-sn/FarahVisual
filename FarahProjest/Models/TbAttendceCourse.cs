using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbAttendceCourse
    {
        public int ClusterId { get; set; }
        public Guid AttendceCourseId { get; set; }
        public Guid? MemberCourseId { get; set; }
        public Guid? VolunteerCourseId { get; set; }
        public Guid? TimeCourseId { get; set; }
        public string StatusAttendce { get; set; }
        public bool? IsVisible { get; set; }

        public virtual TbMemberCourse MemberCourse { get; set; }
        public virtual TbTimeCourse TimeCourse { get; set; }
        public virtual TbVolunteerCourse VolunteerCourse { get; set; }
    }
}

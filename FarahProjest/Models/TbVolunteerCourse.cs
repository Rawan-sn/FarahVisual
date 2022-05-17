using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbVolunteerCourse
    {
        public TbVolunteerCourse()
        {
            TbAttendceCourses = new HashSet<TbAttendceCourse>();
        }

        public int ClusterId { get; set; }
        public Guid VolunteerCourseId { get; set; }
        public Guid CourseId { get; set; }
        public Guid VolunteerId { get; set; }
        public string Result { get; set; }
        public bool? IsVisible { get; set; }
        public string Status { get; set; }
        public string StatusResult { get; set; }

        public virtual TbCourse Course { get; set; }
        public virtual TbVolunteer Volunteer { get; set; }
        public virtual ICollection<TbAttendceCourse> TbAttendceCourses { get; set; }
    }
}

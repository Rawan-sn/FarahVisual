using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbTimeCourse
    {
        public TbTimeCourse()
        {
            TbAttendceCourses = new HashSet<TbAttendceCourse>();
        }

        public int ClusterId { get; set; }
        public Guid TimeCourseId { get; set; }
        public DateTime? DateCourse { get; set; }
        public string TimeCourse { get; set; }
        public Guid? CourseId { get; set; }
        public bool? IsVisible { get; set; }

        public virtual TbCourse Course { get; set; }
        public virtual ICollection<TbAttendceCourse> TbAttendceCourses { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbCourse
    {
        public TbCourse()
        {
            TbMemberCourses = new HashSet<TbMemberCourse>();
            TbVolunteerCourses = new HashSet<TbVolunteerCourse>();
        }

        public int ClusterId { get; set; }
        public Guid CourseId { get; set; }
        public string NameCourse { get; set; }
        public string Description { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string TargetCourse { get; set; }
        public string Place { get; set; }
        public int? MaxMember { get; set; }
        public bool? IsVisible { get; set; }

        public virtual ICollection<TbMemberCourse> TbMemberCourses { get; set; }
        public virtual ICollection<TbVolunteerCourse> TbVolunteerCourses { get; set; }
    }
}

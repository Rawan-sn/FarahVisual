using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbMemberCourse
    {
        public int ClusterId { get; set; }
        public Guid MemberCourseId { get; set; }
        public Guid CourseId { get; set; }
        public Guid FamilyMemberId { get; set; }
        public string Result { get; set; }
        public bool? IsVisible { get; set; }

        public virtual TbCourse Course { get; set; }
        public virtual TbFamilyMember FamilyMember { get; set; }
    }
}

using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbVolunteer
    {
        public TbVolunteer()
        {
            TbVolunteerActivities = new HashSet<TbVolunteerActivity>();
            TbVolunteerCourses = new HashSet<TbVolunteerCourse>();
        }

        public int ClusterId { get; set; }
        public Guid VolunteerId { get; set; }
        public Guid? UserId { get; set; }
        public Guid? SkillId { get; set; }
        public string VolunteerName { get; set; }
        public string Gender { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public int? Age { get; set; }
        public string SocialStatus { get; set; }
        public bool? IsUniversity { get; set; }
        public bool? IsVisible { get; set; }

        public virtual TbSkill Skill { get; set; }
        public virtual ICollection<TbVolunteerActivity> TbVolunteerActivities { get; set; }
        public virtual ICollection<TbVolunteerCourse> TbVolunteerCourses { get; set; }
    }
}

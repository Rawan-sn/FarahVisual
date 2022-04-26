using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbSkill
    {
        public TbSkill()
        {
            TbVolunteers = new HashSet<TbVolunteer>();
        }

        public int ClusterId { get; set; }
        public Guid SkillId { get; set; }
        public string NameSkill { get; set; }
        public bool? IsVisible { get; set; }

        public virtual ICollection<TbVolunteer> TbVolunteers { get; set; }
    }
}

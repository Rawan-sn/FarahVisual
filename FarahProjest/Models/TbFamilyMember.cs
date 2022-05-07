using System;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbFamilyMember
    {
        public TbFamilyMember()
        {
            TbMemberActivities = new HashSet<TbMemberActivity>();
            TbMemberCourses = new HashSet<TbMemberCourse>();
        }

        public int ClusterId { get; set; }
        public Guid FamilyMemberId { get; set; }
        public Guid? FamilyBeneficiaryId { get; set; }
        public Guid? FileFamilyId { get; set; }
        public string MemberName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string TypeMember { get; set; }
        public string ClassMember { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public string SocialState { get; set; }
        public string HealthState { get; set; }
        public bool? IsSchool { get; set; }
        public bool? IsUniversity { get; set; }
        public bool? IsVisible { get; set; }
        public int? Age { get; set; }

        public virtual ICollection<TbMemberActivity> TbMemberActivities { get; set; }
        public virtual ICollection<TbMemberCourse> TbMemberCourses { get; set; }

        internal Task<IEnumerable<TbFamilyMember>> ToListAsync()
        {

            throw new NotImplementedException();
        }
    }
}

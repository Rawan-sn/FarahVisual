using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbMonthlySalary
    {
        public int ClusterId { get; set; }
        public Guid MonthlySalaryId { get; set; }
        public DateTime? RecievedDate { get; set; }
        public string RecievedName { get; set; }
        public bool? IsVisible { get; set; }
        public int? SalaryNumber { get; set; }
        public int? SalaryValue { get; set; }
        public Guid? SignaturePic { get; set; }
        public DateTime? SalaryDate { get; set; }
        public Guid? FamilyBeneficiaryId { get; set; }

        public virtual TbFamilyBeneficiary FamilyBeneficiary { get; set; }
    }
}

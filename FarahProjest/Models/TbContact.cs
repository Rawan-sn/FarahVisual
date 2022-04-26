using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbContact
    {
        public int ClusterId { get; set; }
        public Guid ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsEmployee { get; set; }
        public bool IsUser { get; set; }
        public Guid? EngineerId { get; set; }
        public bool? IsVisible { get; set; }
        public DateTime CreateDate { get; set; }
    }
}

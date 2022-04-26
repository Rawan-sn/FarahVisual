using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbUserInRole
    {
        public int ClusterId { get; set; }
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }
    }
}

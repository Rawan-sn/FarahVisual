using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbGoogleUser
    {
        public int ClusterId { get; set; }
        public Guid UserId { get; set; }
        public string GoogleId { get; set; }
        public string DisplayName { get; set; }
        public bool Gender { get; set; }
        public Guid FileId { get; set; }
    }
}

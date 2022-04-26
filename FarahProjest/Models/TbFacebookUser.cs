using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbFacebookUser
    {
        public int ClusterId { get; set; }
        public Guid UserId { get; set; }
        public string FaceBookId { get; set; }
        public string UserName { get; set; }
        public Guid? FileId { get; set; }
        public string Name { get; set; }
    }
}

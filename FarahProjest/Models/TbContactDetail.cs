using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbContactDetail
    {
        public int ClusterId { get; set; }
        public Guid ContactId { get; set; }
        public Guid? PicFileId { get; set; }
        public Guid? NationalityId { get; set; }
    }
}

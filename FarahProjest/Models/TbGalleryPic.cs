using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbGalleryPic
    {
        public int ClusterId { get; set; }
        public Guid GalleryPicId { get; set; }
        public Guid GalleryId { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime? InsertDate { get; set; }
        public bool? IsVisible { get; set; }
        public bool? IsApprove { get; set; }
        public Guid? PicId { get; set; }
    }
}

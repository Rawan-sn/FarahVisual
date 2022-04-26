using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbGallery
    {
        public int ClusterId { get; set; }
        public Guid GalleryId { get; set; }
        public int? Total { get; set; }
        public bool IsVisible { get; set; }
        public bool IsApprove { get; set; }
        public Guid? PicId { get; set; }
        public Guid? UserId { get; set; }
        public string Title { get; set; }
        public bool? IsProjects { get; set; }
        public string Details { get; set; }
    }
}

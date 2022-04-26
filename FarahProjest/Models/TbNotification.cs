using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbNotification
    {
        public int ClusterId { get; set; }
        public Guid NotificationId { get; set; }
        public string NotificationName { get; set; }
        public string NotificationDescription { get; set; }
        public bool? IsVisible { get; set; }
    }
}

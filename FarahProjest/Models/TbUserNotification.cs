using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbUserNotification
    {
        public int ClusterId { get; set; }
        public Guid UserNotification { get; set; }
        public Guid? NotificationId { get; set; }
        public Guid? UserId { get; set; }
        public bool? IsVisible { get; set; }
    }
}

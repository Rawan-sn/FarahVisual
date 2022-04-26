using System;
using System.Collections.Generic;

#nullable disable

namespace FarahProjest.Models
{
    public partial class TbTempAuth
    {
        public int ClusterId { get; set; }
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string AuthCode { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class Notification
    {
        public int NotificationId { get; set; }
        public bool NotifyByEmail { get; set; }
        public bool NotifyOnDashboard { get; set; }
        public int UserId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public User User { get; set; }
    }
}

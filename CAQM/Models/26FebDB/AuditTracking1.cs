using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class AuditTracking1
    {
        public long AuditTrackingId { get; set; }
        public string TableName { get; set; }
        public string PreviousValue { get; set; }
        public string CurrentValue { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}

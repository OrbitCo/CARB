using System;
using System.Collections.Generic;

namespace CAQM.Models.19FEB
{
    public partial class SiteMonitorHistory
    {
        public int SiteMonitorHistoryId { get; set; }
        public int SiteMonitorId { get; set; }
        public string ActionTaken { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public SiteMonitor SiteMonitor { get; set; }
    }
}

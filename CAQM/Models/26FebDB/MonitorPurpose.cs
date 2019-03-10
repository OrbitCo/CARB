using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class MonitorPurpose
    {
        public MonitorPurpose()
        {
            SiteMonitor = new HashSet<SiteMonitor>();
        }

        public int MonitorPurposeId { get; set; }
        public string MonitorPurposeCode { get; set; }
        public string MonitorPurpose1 { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<SiteMonitor> SiteMonitor { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace CAQM.Models.19FEB
{
    public partial class MonitorPurpose1
    {
        public MonitorPurpose1()
        {
            SiteMonitor = new HashSet<SiteMonitor>();
        }

        public int MonitorPurposeId { get; set; }
        public int MonitorPurposeCode { get; set; }
        public string MonitorPurpose { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<SiteMonitor> SiteMonitor { get; set; }
    }
}

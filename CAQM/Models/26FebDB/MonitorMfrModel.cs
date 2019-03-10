using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class MonitorMfrModel
    {
        public MonitorMfrModel()
        {
            MonitorMfrModelParameter = new HashSet<MonitorMfrModelParameter>();
            SiteMonitor = new HashSet<SiteMonitor>();
        }

        public int MonitorMfrModelId { get; set; }
        public string MonitorManufacturer { get; set; }
        public string MonitorModel { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<MonitorMfrModelParameter> MonitorMfrModelParameter { get; set; }
        public ICollection<SiteMonitor> SiteMonitor { get; set; }
    }
}

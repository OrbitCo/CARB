using System;
using System.Collections.Generic;

namespace CAQM.Models.19FEB
{
    public partial class Monitor1
    {
        public Monitor1()
        {
            SiteMonitor = new HashSet<SiteMonitor>();
        }

        public int MonitorId { get; set; }
        public int DataProviderMonitorCode { get; set; }
        public string MonitorManufacturer { get; set; }
        public string MonitorModel { get; set; }
        public int? InletOrientation { get; set; }
        public double? InletHeight { get; set; }
        public double? InletDiameter { get; set; }
        public string FlowRate { get; set; }
        public int? MeasurementResolution { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<SiteMonitor> SiteMonitor { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class SiteMonitor
    {
        public SiteMonitor()
        {
            SiteMonitorHistory = new HashSet<SiteMonitorHistory>();
            SiteMonitorParameter = new HashSet<SiteMonitorParameter>();
        }

        public int SiteMonitorId { get; set; }
        public int SiteLocationId { get; set; }
        public int MonitorMfrModelId { get; set; }
        public string DataProviderAssignedMonitorCode { get; set; }
        public int? MonitorPurposeId { get; set; }
        public string FirmwareVersion { get; set; }
        public DateTime? MonitorPurchaseDate { get; set; }
        public DateTime? LastServiceDate { get; set; }
        public bool? Cfrsiting { get; set; }
        public string FlowRate { get; set; }
        public double? InletHeight { get; set; }
        public int? InletOrientation { get; set; }
        public double? InletDiameter { get; set; }
        public string SystemDescription { get; set; }
        public bool? IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public MonitorMfrModel MonitorMfrModel { get; set; }
        public MonitorPurpose MonitorPurpose { get; set; }
        public SiteLocation SiteLocation { get; set; }
        public ICollection<SiteMonitorHistory> SiteMonitorHistory { get; set; }
        public ICollection<SiteMonitorParameter> SiteMonitorParameter { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace CAQM.Models.19FEB
{
    public partial class SiteMonitor
    {
        public SiteMonitor()
        {
            SiteMonitorHistory = new HashSet<SiteMonitorHistory>();
            SiteMonitorParameter = new HashSet<SiteMonitorParameter>();
        }

        public int SiteMonitorId { get; set; }
        public int MonitorSiteId { get; set; }
        public int MonitorId { get; set; }
        public string DataProviderAssignedMonitorCode { get; set; }
        public int? MonitorPurposeId { get; set; }
        public bool? CfrguidelinesAreFollowed { get; set; }
        public string FirmwareVersion { get; set; }
        public string MeasurementPrecision { get; set; }
        public string SystemDescription { get; set; }
        public DateTime? MonitorPurchaseDate { get; set; }
        public DateTime? LastServiceDate { get; set; }
        public bool? IsActive { get; set; }
        public string ActionTaken { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public Monitor1 Monitor { get; set; }
        public MonitorPurpose1 MonitorPurpose { get; set; }
        public MonitorSite MonitorSite { get; set; }
        public ICollection<SiteMonitorHistory> SiteMonitorHistory { get; set; }
        public ICollection<SiteMonitorParameter> SiteMonitorParameter { get; set; }
    }
}

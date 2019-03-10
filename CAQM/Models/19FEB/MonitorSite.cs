using System;
using System.Collections.Generic;

namespace CAQM.Models.19FEB
{
    public partial class MonitorSite
    {
        public MonitorSite()
        {
            SiteMonitor = new HashSet<SiteMonitor>();
        }

        public int MonitorSiteId { get; set; }
        public int CommunityId { get; set; }
        public string CarbassignedSiteCode { get; set; }
        public string DataProviderAssignedSiteCode { get; set; }
        public string SiteName { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public decimal Elevation { get; set; }
        public bool? IsActive { get; set; }
        public string ActionTaken { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public Community1 Community { get; set; }
        public ICollection<SiteMonitor> SiteMonitor { get; set; }
    }
}

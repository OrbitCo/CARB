using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class SiteLocation
    {
        public SiteLocation()
        {
            SiteLocationHistory = new HashSet<SiteLocationHistory>();
            SiteMonitor = new HashSet<SiteMonitor>();
        }

        public int SiteLocationId { get; set; }
        public int CommunityId { get; set; }
        public string CarbassignedSiteCode { get; set; }
        public string DataProviderAssignedSiteCode { get; set; }
        public string SiteName { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public decimal Elevation { get; set; }
        public bool? IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public Community1 Community { get; set; }
        public ICollection<SiteLocationHistory> SiteLocationHistory { get; set; }
        public ICollection<SiteMonitor> SiteMonitor { get; set; }
    }
}

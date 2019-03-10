using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class SiteLocationHistory
    {
        public int SiteLocationHistoryId { get; set; }
        public int SiteLocationId { get; set; }
        public string OriginalDataProviderAssignedSiteCode { get; set; }
        public string OriginalSiteName { get; set; }
        public decimal OriginalLatitude { get; set; }
        public decimal OriginalLongitude { get; set; }
        public decimal OriginalElevation { get; set; }
        public string NewDataProviderAssignedSiteCode { get; set; }
        public string NewSiteName { get; set; }
        public decimal NewLatitude { get; set; }
        public decimal NewLongitude { get; set; }
        public decimal NewElevation { get; set; }
        public string Explanation { get; set; }
        public bool? IsApproved { get; set; }
        public int ApprovedBy { get; set; }
        public DateTime ApprovedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public SiteLocation SiteLocation { get; set; }
    }
}

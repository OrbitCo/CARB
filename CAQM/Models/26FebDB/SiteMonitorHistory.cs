using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class SiteMonitorHistory
    {
        public int SiteMonitorHistoryId { get; set; }
        public int SiteMonitorId { get; set; }
        public int OriginalSiteLocationId { get; set; }
        public int OriginalMonitorMfrModelId { get; set; }
        public string OriginalDataProviderAssignedMonitorCode { get; set; }
        public int? OriginalMonitorPurposeId { get; set; }
        public string OriginalFirmwareVersion { get; set; }
        public DateTime? OriginalMonitorPurchaseDate { get; set; }
        public DateTime? OriginalLastServiceDate { get; set; }
        public bool? OriginalCfrsiting { get; set; }
        public string OriginalFlowRate { get; set; }
        public double? OriginalInletHeight { get; set; }
        public int? OriginalInletOrientation { get; set; }
        public double? OriginalInletDiameter { get; set; }
        public string OriginalSystemDescription { get; set; }
        public bool? OriginalIsActive { get; set; }
        public int NewSiteLocationId { get; set; }
        public int NewMonitorMfrModelId { get; set; }
        public string NewDataProviderAssignedMonitorCode { get; set; }
        public int? NewMonitorPurposeId { get; set; }
        public string NewFirmwareVersion { get; set; }
        public DateTime? NewMonitorPurchaseDate { get; set; }
        public DateTime? NewLastServiceDate { get; set; }
        public bool? NewCfrsiting { get; set; }
        public string NewFlowRate { get; set; }
        public double? NewInletHeight { get; set; }
        public int? NewInletOrientation { get; set; }
        public double? NewInletDiameter { get; set; }
        public string NewSystemDescription { get; set; }
        public bool? NewIsActive { get; set; }
        public string Explanation { get; set; }
        public bool? IsApproved { get; set; }
        public int ApprovedBy { get; set; }
        public DateTime ApprovedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public SiteMonitor SiteMonitor { get; set; }
    }
}

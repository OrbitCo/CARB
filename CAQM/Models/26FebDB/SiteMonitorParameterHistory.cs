using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class SiteMonitorParameterHistory
    {
        public int SiteMonitorParameterHistoryId { get; set; }
        public int SiteMonitorParameterId { get; set; }
        public int? OriginalMeasurementTechniqueId { get; set; }
        public int OriginalMeasurementUnitId { get; set; }
        public int? OriginalSampleDurationId { get; set; }
        public int? OriginalSampleFrequencyId { get; set; }
        public int? OriginalDetectionRangeUnitId { get; set; }
        public double? OriginalUpperDetectionLimit { get; set; }
        public double? OriginalLowerDetectionLimit { get; set; }
        public double? OriginalMethodDetectionLimit { get; set; }
        public string OriginalMonitorUncertainty { get; set; }
        public string OriginalMonitorPrecision { get; set; }
        public int? OriginalMeasurementResolution { get; set; }
        public DateTime? OriginalLastCalibrationTimestamp { get; set; }
        public bool? OriginalIsActive { get; set; }
        public int? NewMeasurementTechniqueId { get; set; }
        public int NewMeasurementUnitId { get; set; }
        public int? NewSampleDurationId { get; set; }
        public int? NewSampleFrequencyId { get; set; }
        public int? NewDetectionRangeUnitId { get; set; }
        public double? NewUpperDetectionLimit { get; set; }
        public double? NewLowerDetectionLimit { get; set; }
        public double? NewMethodDetectionLimit { get; set; }
        public string NewMonitorUncertainty { get; set; }
        public string NewMonitorPrecision { get; set; }
        public int? NewMeasurementResolution { get; set; }
        public DateTime? NewLastCalibrationTimestamp { get; set; }
        public bool? NewIsActive { get; set; }
        public string Explanation { get; set; }
        public bool? IsApproved { get; set; }
        public int ApprovedBy { get; set; }
        public DateTime ApprovedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public SiteMonitorParameter SiteMonitorParameter { get; set; }
    }
}

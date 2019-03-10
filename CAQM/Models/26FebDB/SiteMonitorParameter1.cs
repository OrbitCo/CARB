using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class SiteMonitorParameter1
    {
        public int SiteMonitorParameterId { get; set; }
        public int SiteMonitorId { get; set; }
        public int ParameterId { get; set; }
        public int? MeasurementTechniqueId { get; set; }
        public int? MeasurementUnitId { get; set; }
        public int? SampleFrequencyId { get; set; }
        public int? SampleDurationId { get; set; }
        public double? UpperDetectionLimit { get; set; }
        public double? LowerDetectionLimit { get; set; }
        public double? MethodDetectionLimit { get; set; }
        public int? DetectionRangeUnitId { get; set; }
        public string Uncertainty { get; set; }
        public DateTime? LastCalibrationTimestamp { get; set; }
        public bool? IsActive { get; set; }
        public bool? AllowStream { get; set; }
        public bool? DisplayStream { get; set; }
        public string ActionTaken { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}

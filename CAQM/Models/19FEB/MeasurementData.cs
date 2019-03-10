using System;
using System.Collections.Generic;

namespace CAQM.Models.19FEB
{
    public partial class MeasurementData
    {
        public long DataFileId { get; set; }
        public long MeasurementDataId { get; set; }
        public string SiteId { get; set; }
        public string MonitorId { get; set; }
        public string SensorId { get; set; }
        public int? ParameterId { get; set; }
        public double? MethodDetectionLimit { get; set; }
        public string DetectionRangeUnits { get; set; }
        public string LabOrganization { get; set; }
        public int? Date { get; set; }
        public TimeSpan? StartTime { get; set; }
        public double? MeasurementValue { get; set; }
        public int MeasurementUnits { get; set; }
        public double? AdjustedMeasurementValue { get; set; }
        public int? AdjustmentTechnique { get; set; }
        public string Uncertainty { get; set; }
        public int? Quality { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string IsApproved { get; set; }
        public int? ApprovedBy { get; set; }
    }
}

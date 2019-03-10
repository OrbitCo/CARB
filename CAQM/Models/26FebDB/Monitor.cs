using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class Monitor
    {
        public int MonitorId { get; set; }
        public string MonitorName { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string LastEntryId { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string SiteId { get; set; }
        public string Elevation { get; set; }
        public string Cfrstring { get; set; }
        public string MonitorPurpose { get; set; }
        public string SensorId { get; set; }
        public string MonitorManufacturer { get; set; }
        public string MonitorModel { get; set; }
        public string FirmwareVersion { get; set; }
        public int? Parameter { get; set; }
        public string MeasurementTechnique { get; set; }
        public string SamplingFrequency { get; set; }
        public string SamplingDuration { get; set; }
        public string UpperDetectionLimit { get; set; }
        public string LowerDetectionLimit { get; set; }
        public string MethodDetectionLimit { get; set; }
        public string DetectionRangeUnits { get; set; }
        public string MonitorUncertainty { get; set; }
        public string Precision { get; set; }
        public string SystemDescription { get; set; }
        public string MonitorPurchaseDate { get; set; }
        public string LastCalibrationTimestamp { get; set; }
        public string LastServiceDate { get; set; }
        public string InletOrientation { get; set; }
        public string InletHeight { get; set; }
        public string InletDiameter { get; set; }
        public string FlowRate { get; set; }
        public string MeasurementResolution { get; set; }
        public string Explanation { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string SystemDescripion { get; set; }
        public bool? Active { get; set; }
        public DateTime? RelocateStartDate { get; set; }
        public DateTime? RelocateEndDate { get; set; }
    }
}

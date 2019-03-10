using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class SiteMonitorParameter
    {
        public SiteMonitorParameter()
        {
            MeasurementStreamData = new HashSet<MeasurementStreamData>();
            SiteMonitorParameterHistory = new HashSet<SiteMonitorParameterHistory>();
        }

        public int SiteMonitorParameterId { get; set; }
        public int SiteMonitorId { get; set; }
        public int ParameterId { get; set; }
        public int? MeasurementTechniqueId { get; set; }
        public int MeasurementUnitId { get; set; }
        public int? SampleDurationId { get; set; }
        public int? SampleFrequencyId { get; set; }
        public int? DetectionRangeUnitId { get; set; }
        public double? UpperDetectionLimit { get; set; }
        public double? LowerDetectionLimit { get; set; }
        public double? MethodDetectionLimit { get; set; }
        public string MonitorUncertainty { get; set; }
        public string MonitorPrecision { get; set; }
        public int? MeasurementResolution { get; set; }
        public DateTime? LastCalibrationTimestamp { get; set; }
        public bool? IsActive { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public MeasurementUnit1 DetectionRangeUnit { get; set; }
        public MeasurementTechnique1 MeasurementTechnique { get; set; }
        public MeasurementUnit1 MeasurementUnit { get; set; }
        public Parameter Parameter { get; set; }
        public SampleDuration SampleDuration { get; set; }
        public SampleFrequency SampleFrequency { get; set; }
        public SiteMonitor SiteMonitor { get; set; }
        public ICollection<MeasurementStreamData> MeasurementStreamData { get; set; }
        public ICollection<SiteMonitorParameterHistory> SiteMonitorParameterHistory { get; set; }
    }
}

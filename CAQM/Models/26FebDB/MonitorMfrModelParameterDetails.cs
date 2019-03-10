using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class MonitorMfrModelParameterDetails
    {
        public int MonitorMfrModelParameterDetailsId { get; set; }
        public int MonitorMfrModelParameterId { get; set; }
        public int? MeasurementTechniqueId { get; set; }
        public int MeasurementUnitId { get; set; }
        public int? SampleDurationId { get; set; }
        public int? SampleFrequencyId { get; set; }
        public int? DetectionRangeUnitId { get; set; }
        public double? UpperDetectionLimit { get; set; }
        public double? LowerDetectionLimit { get; set; }
        public double? MethodDetectionLimit { get; set; }
        public string Uncertainty { get; set; }
        public string MonitorPrecision { get; set; }
        public int? MeasurementResolution { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public MeasurementUnit1 DetectionRangeUnit { get; set; }
        public MeasurementTechnique1 MeasurementTechnique { get; set; }
        public MeasurementUnit1 MeasurementUnit { get; set; }
        public MonitorMfrModelParameter MonitorMfrModelParameter { get; set; }
        public SampleDuration SampleDuration { get; set; }
        public SampleFrequency SampleFrequency { get; set; }
    }
}

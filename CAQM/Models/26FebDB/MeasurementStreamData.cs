using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class MeasurementStreamData
    {
        public Guid MeasurementStreamDataId { get; set; }
        public int MeasurementFileId { get; set; }
        public int SiteMonitorParameterId { get; set; }
        public DateTime MeasurementDateTime { get; set; }
        public int MeasurementUnitId { get; set; }
        public int? DetectionRangeUnitId { get; set; }
        public int? AdjustmentTechniqueId { get; set; }
        public int? QualityFlagId { get; set; }
        public double? MethodDetectionLimit { get; set; }
        public int? LabOrganizationId { get; set; }
        public string Uncertainty { get; set; }
        public double ChannelAmeasurement { get; set; }
        public double? ChannelBmeasurement { get; set; }
        public double? ChannelCmeasurement { get; set; }
        public double? ChannelAmeasurementAdjusted { get; set; }
        public double? ChannelBmeasurementAdjusted { get; set; }
        public double? ChannelCmeasurementAdjusted { get; set; }
        public bool? AllowStream { get; set; }
        public bool? DisplayStream { get; set; }

        public AdjustmentTechnique AdjustmentTechnique { get; set; }
        public MeasurementUnit1 DetectionRangeUnit { get; set; }
        public LabOrganization LabOrganization { get; set; }
        public MeasurementFile MeasurementFile { get; set; }
        public MeasurementUnit1 MeasurementUnit { get; set; }
        public QualityFlag QualityFlag { get; set; }
        public SiteMonitorParameter SiteMonitorParameter { get; set; }
    }
}

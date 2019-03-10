using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CAQM.Entities
{
    public class MeasurementData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long MeasurementDataId { get; set; }

        public long DataFileId { get; set; }

       // public string SiteId { get; set; }
        public string MonitorId { get; set; }        
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
        public decimal ChannelAMeasurementValue { get; set; }
        public decimal ChannelBMeasurementValue { get; set; }
        public decimal ChannelCMeasurementValue { get; set; }
        public decimal ChannelAAdjustedMeasurementValue { get; set; }
        public decimal ChannelDAdjustedMeasurementValue { get; set; }
        public decimal ChannelCAdjustedMeasurementValue { get; set; }
    }
}

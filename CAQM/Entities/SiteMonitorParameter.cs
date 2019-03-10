using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CAQM.Entities
{
    public class SiteMonitorParameter
    {
        [Key]
        public int SiteMonitorParameterId { get; set; }
        public string SiteMonitorId { get; set; }
        public int ParameterId { get; set; }
        public int? MeasurementTechniqueId { get; set; }
        public int MeasurementUnitId { get; set; }
        public string SampleFrequencyId { get; set; }
        public int? SampleDurationId { get; set; }
        public double? UpperDetectionLimit { get; set; }
        public double? LowerDetectionLimit { get; set; }
        public double? MethodDetectionLimit { get; set; }
        public int? DetectionRangeUnitId { get; set; }

        public string Uncertainty { get; set; }
        //public string MonitorPrecision { get; set; }
        //public string MeasurementResolution { get; set; }       

        public DateTime? LastCalibrationTimestamp { get; set; }
        public bool? IsActive { get; set; }
        public bool? AllowStream { get; set; }
        public bool? DisplayStream { get; set; }
        public string ActionTaken { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }



        /*THESE ARE REFERENCE TABLE, COMMENTING FOR NOW*/

        //public MeasurementTechniques MeasurementTechnique { get; set; }
        //public MeasurementUnit1 MeasurementUnit { get; set; }
        //public Parameters Parameter { get; set; }
        //public SampleDurations SampleDuration { get; set; }
        //public SampleFrequency SampleFrequency { get; set; }
        //public SiteMonitor SiteMonitor { get; set; }
    }
}

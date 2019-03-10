using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class MeasurementUnit1
    {
        public MeasurementUnit1()
        {
            MeasurementStreamDataDetectionRangeUnit = new HashSet<MeasurementStreamData>();
            MeasurementStreamDataMeasurementUnit = new HashSet<MeasurementStreamData>();
            MonitorMfrModelParameterDetailsDetectionRangeUnit = new HashSet<MonitorMfrModelParameterDetails>();
            MonitorMfrModelParameterDetailsMeasurementUnit = new HashSet<MonitorMfrModelParameterDetails>();
            SiteMonitorParameterDetectionRangeUnit = new HashSet<SiteMonitorParameter>();
            SiteMonitorParameterMeasurementUnit = new HashSet<SiteMonitorParameter>();
        }

        public int MeasurementUnitId { get; set; }
        public string MeasurementUnitCode { get; set; }
        public string MeasurementUnitAbbreviation { get; set; }
        public string MeasurementUnitDescription { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<MeasurementStreamData> MeasurementStreamDataDetectionRangeUnit { get; set; }
        public ICollection<MeasurementStreamData> MeasurementStreamDataMeasurementUnit { get; set; }
        public ICollection<MonitorMfrModelParameterDetails> MonitorMfrModelParameterDetailsDetectionRangeUnit { get; set; }
        public ICollection<MonitorMfrModelParameterDetails> MonitorMfrModelParameterDetailsMeasurementUnit { get; set; }
        public ICollection<SiteMonitorParameter> SiteMonitorParameterDetectionRangeUnit { get; set; }
        public ICollection<SiteMonitorParameter> SiteMonitorParameterMeasurementUnit { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class SampleDuration
    {
        public SampleDuration()
        {
            MonitorMfrModelParameterDetails = new HashSet<MonitorMfrModelParameterDetails>();
            SiteMonitorParameter = new HashSet<SiteMonitorParameter>();
        }

        public int SampleDurationId { get; set; }
        public string SampleDurationCode { get; set; }
        public string SampleDurationDescription { get; set; }
        public string ObservedOrCalculated { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<MonitorMfrModelParameterDetails> MonitorMfrModelParameterDetails { get; set; }
        public ICollection<SiteMonitorParameter> SiteMonitorParameter { get; set; }
    }
}

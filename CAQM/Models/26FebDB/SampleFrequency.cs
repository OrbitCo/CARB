using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class SampleFrequency
    {
        public SampleFrequency()
        {
            MonitorMfrModelParameterDetails = new HashSet<MonitorMfrModelParameterDetails>();
            SiteMonitorParameter = new HashSet<SiteMonitorParameter>();
        }

        public int SampleFrequencyId { get; set; }
        public string SampleFrequencyCode { get; set; }
        public string SampleFrequencyDescription { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<MonitorMfrModelParameterDetails> MonitorMfrModelParameterDetails { get; set; }
        public ICollection<SiteMonitorParameter> SiteMonitorParameter { get; set; }
    }
}

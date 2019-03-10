using System;
using System.Collections.Generic;

namespace CAQM.Models.19FEB
{
    public partial class SampleDuration1
    {
        public SampleDuration1()
        {
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

        public ICollection<SiteMonitorParameter> SiteMonitorParameter { get; set; }
    }
}

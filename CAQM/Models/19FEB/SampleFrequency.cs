using System;
using System.Collections.Generic;

namespace CAQM.Models.19FEB
{
    public partial class SampleFrequency
    {
        public SampleFrequency()
        {
            SiteMonitorParameter = new HashSet<SiteMonitorParameter>();
        }

        public int SampleFrequencyId { get; set; }
        public string SampleFrequencyCode { get; set; }
        public string SampleFrequencyDescription { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<SiteMonitorParameter> SiteMonitorParameter { get; set; }
    }
}

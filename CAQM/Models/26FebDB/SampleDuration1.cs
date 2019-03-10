using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class SampleDuration1
    {
        public SampleDuration1()
        {
            SetupMetadata = new HashSet<SetupMetadata>();
        }

        public int SampleDurationId { get; set; }
        public string SampleDurationCode { get; set; }
        public string SampleDurationDescription { get; set; }
        public string ObservedOrCalculated { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<SetupMetadata> SetupMetadata { get; set; }
    }
}

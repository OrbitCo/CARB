using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class Parameter1
    {
        public Parameter1()
        {
            SetupMetadata = new HashSet<SetupMetadata>();
        }

        public int ParameterId { get; set; }
        public int ParameterCode { get; set; }
        public string Parameter { get; set; }
        public string StandardUnits { get; set; }
        public string RoundOrTruncate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<SetupMetadata> SetupMetadata { get; set; }
    }
}

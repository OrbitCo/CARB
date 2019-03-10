using System;
using System.Collections.Generic;

namespace CAQM.Models.19FEB
{
    public partial class SampleAnalysisLab
    {
        public int SampleAnalysisLabId { get; set; }
        public string SampleAnalysisLabName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}

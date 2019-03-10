using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class SampleQualityCode
    {
        public int SampleQualityCodeId { get; set; }
        public int SampleQualityCode1 { get; set; }
        public string SampleQualityDescription { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}

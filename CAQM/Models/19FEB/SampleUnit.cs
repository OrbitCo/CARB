using System;
using System.Collections.Generic;

namespace CAQM.Models.19FEB
{
    public partial class SampleUnit
    {
        public int SampleUnitId { get; set; }
        public string SampleUnitCode { get; set; }
        public string SampleUnitDescription { get; set; }
        public string SampleUnitAbbreviation { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}

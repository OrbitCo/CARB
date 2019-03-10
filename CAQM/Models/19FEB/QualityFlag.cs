using System;
using System.Collections.Generic;

namespace CAQM.Models.19FEB
{
    public partial class QualityFlag
    {
        public int QualityFlagId { get; set; }
        public int DataProviderId { get; set; }
        public string DataProviderFlag { get; set; }
        public string FlagDescription { get; set; }
        public int? InternalFlag { get; set; }
        public string InternalFlagDescription { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public DataProvider1 DataProvider { get; set; }
    }
}

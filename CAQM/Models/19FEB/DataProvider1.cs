using System;
using System.Collections.Generic;

namespace CAQM.Models.19FEB
{
    public partial class DataProvider1
    {
        public DataProvider1()
        {
            AdjustmentTechnique = new HashSet<AdjustmentTechnique>();
            QualityFlag = new HashSet<QualityFlag>();
        }

        public int DataProviderId { get; set; }
        public string DataProviderCode { get; set; }
        public string DataProviderShortName { get; set; }
        public string DataProviderLongName { get; set; }
        public string DataProviderCategory { get; set; }
        public string AqsagencyCode { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<AdjustmentTechnique> AdjustmentTechnique { get; set; }
        public ICollection<QualityFlag> QualityFlag { get; set; }
    }
}

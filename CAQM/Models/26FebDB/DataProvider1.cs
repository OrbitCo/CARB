using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class DataProvider1
    {
        public DataProvider1()
        {
            AdjustmentTechnique = new HashSet<AdjustmentTechnique>();
            QualityFlag = new HashSet<QualityFlag>();
            UserDataProvider = new HashSet<UserDataProvider>();
        }

        public int DataProviderId { get; set; }
        public string DataProviderCode { get; set; }
        public string DataProviderShortName { get; set; }
        public string DataProviderLongName { get; set; }
        public string DataProviderType { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<AdjustmentTechnique> AdjustmentTechnique { get; set; }
        public ICollection<QualityFlag> QualityFlag { get; set; }
        public ICollection<UserDataProvider> UserDataProvider { get; set; }
    }
}

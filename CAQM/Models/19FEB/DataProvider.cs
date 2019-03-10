using System;
using System.Collections.Generic;

namespace CAQM.Models.19FEB
{
    public partial class DataProvider
    {
        public DataProvider()
        {
            SetupMetadata = new HashSet<SetupMetadata>();
        }

        public int DataProviderId { get; set; }
        public int DataProviderCode { get; set; }
        public string DataProviderLongName { get; set; }
        public string DataProviderShortName { get; set; }
        public string DataProviderType { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<SetupMetadata> SetupMetadata { get; set; }
    }
}

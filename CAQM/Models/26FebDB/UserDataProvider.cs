using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class UserDataProvider
    {
        public UserDataProvider()
        {
            DataProviderCommunity = new HashSet<DataProviderCommunity>();
        }

        public int UserDataProviderId { get; set; }
        public int UserId { get; set; }
        public int DataProviderId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public DataProvider1 DataProvider { get; set; }
        public User User { get; set; }
        public ICollection<DataProviderCommunity> DataProviderCommunity { get; set; }
    }
}

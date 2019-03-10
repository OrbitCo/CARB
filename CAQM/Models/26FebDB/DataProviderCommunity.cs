using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class DataProviderCommunity
    {
        public int DataProviderCommunityId { get; set; }
        public int UserDataProviderId { get; set; }
        public int CommunityId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public Community1 Community { get; set; }
        public UserDataProvider UserDataProvider { get; set; }
    }
}

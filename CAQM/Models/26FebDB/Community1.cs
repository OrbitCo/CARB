using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class Community1
    {
        public Community1()
        {
            DataProviderCommunity = new HashSet<DataProviderCommunity>();
            SiteLocation = new HashSet<SiteLocation>();
        }

        public int CommunityId { get; set; }
        public int DataProviderId { get; set; }
        public string DataProviderCode { get; set; }
        public string CommunityName { get; set; }
        public string AirBasinName { get; set; }
        public string AirDistrictName { get; set; }
        public string CountyName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<DataProviderCommunity> DataProviderCommunity { get; set; }
        public ICollection<SiteLocation> SiteLocation { get; set; }
    }
}

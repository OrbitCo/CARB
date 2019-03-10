using System;
using System.Collections.Generic;

namespace CAQM.Models.19FEB
{
    public partial class Community
    {
        public Community()
        {
            SetupMetadata = new HashSet<SetupMetadata>();
        }

        public int CommunityId { get; set; }
        public string CommunityName { get; set; }
        public string ProjectName { get; set; }
        public string StateName { get; set; }
        public string AirBasin { get; set; }
        public string AirDistrict { get; set; }
        public string County { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<SetupMetadata> SetupMetadata { get; set; }
    }
}

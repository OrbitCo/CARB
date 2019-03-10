using System;
using System.Collections.Generic;

namespace CAQM.Models.19FEB
{
    public partial class Community1
    {
        public Community1()
        {
            MonitorSite = new HashSet<MonitorSite>();
        }

        public int CommunityId { get; set; }
        public string CommunityName { get; set; }
        public string ProjectName { get; set; }
        public string AirBasin { get; set; }
        public string AirDistrict { get; set; }
        public string County { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<MonitorSite> MonitorSite { get; set; }
    }
}

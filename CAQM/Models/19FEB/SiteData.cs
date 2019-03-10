using System;
using System.Collections.Generic;

namespace CAQM.Models.19FEB
{
    public partial class SiteData
    {
        public int Id { get; set; }
        public string SiteId { get; set; }
        public string Elevation { get; set; }
        public string SiteName { get; set; }
        public string CommunityProjectName { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int? Active { get; set; }
        public int? UserId { get; set; }

        public User User { get; set; }
    }
}

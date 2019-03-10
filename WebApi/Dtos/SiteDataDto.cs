using System;

namespace WebApi.Dtos
{
    public class SiteDataDto
    {
        public string SiteId { get; set; }
        public string SiteElevation { get; set; }
        public string SiteName { get; set; }
        public string CommunityProjectName { get; set; }
        public decimal? SiteLatitude { get; set; }
        public decimal? SiteLongitude { get; set; }

        public string CommunityName { get; set; }
        public string Explanation { get; set; }
        public DateTime? DateStart { get; set; }
        public DateTime? DateEnd { get; set; }

        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Dtos
{
    public class UserSiteDataDto
    {
        public int userId { get; set; }
        public List<UserSites> userSites { get; set; }
    }

    public class UserSites
    {
        public bool active { get; set; }
        public string communityProjectName { get; set; }
        public string siteName { get; set; }
        public string siteId { get; set; }
        public decimal? siteLatitude { get; set; }
        public decimal? siteLongitude { get; set; }
        public string siteElevation { get; set; }
        public List<SiteMonitor> siteMonitors { get; set; }
        
    }
    public class SiteMonitor
    {
        public List<UserSites> userSites { get; set; }
    }
    public class UserSites1
    {
        public List<UserSites> userSites { get; set; }
    }
    public class UserSites2
    {
        public List<UserSites> userSites { get; set; }
    }
}

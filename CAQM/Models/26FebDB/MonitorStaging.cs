using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class MonitorStaging
    {
        public MonitorStaging()
        {
            TimeSeriesStaging = new HashSet<TimeSeriesStaging>();
        }

        public int MonitorStagingId { get; set; }
        public string MonitorName { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public string Field1 { get; set; }
        public string Field2 { get; set; }
        public string Field3 { get; set; }
        public string Field4 { get; set; }
        public string Field5 { get; set; }
        public string Field6 { get; set; }
        public string Field7 { get; set; }
        public string Field8 { get; set; }
        public string LastEntryId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public User1 CreatedByNavigation { get; set; }
        public User1 UpdatedByNavigation { get; set; }
        public ICollection<TimeSeriesStaging> TimeSeriesStaging { get; set; }
    }
}

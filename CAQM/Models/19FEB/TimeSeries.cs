using System;
using System.Collections.Generic;

namespace CAQM.Models.19FEB
{
    public partial class TimeSeries
    {
        public long TimeSeriesId { get; set; }
        public int MonitorId { get; set; }
        public decimal? Field1 { get; set; }
        public decimal? Field2 { get; set; }
        public decimal? Field3 { get; set; }
        public decimal? Field4 { get; set; }
        public decimal? Field5 { get; set; }
        public decimal? Field6 { get; set; }
        public decimal? Field7 { get; set; }
        public decimal? Field8 { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public User CreatedByNavigation { get; set; }
        public Monitor Monitor { get; set; }
        public User UpdatedByNavigation { get; set; }
    }
}

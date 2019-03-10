using System;
using System.Collections.Generic;

namespace CAQM.Models.19FEB
{
    public partial class MeasurementUnit1
    {
        public MeasurementUnit1()
        {
            SiteMonitorParameter = new HashSet<SiteMonitorParameter>();
        }

        public int MeasurementUnitId { get; set; }
        public string MeasurementUnitCode { get; set; }
        public string MeasurementUnitAbbreviation { get; set; }
        public string MeasurementUnitDescription { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<SiteMonitorParameter> SiteMonitorParameter { get; set; }
    }
}

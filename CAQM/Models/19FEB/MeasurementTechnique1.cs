using System;
using System.Collections.Generic;

namespace CAQM.Models.19FEB
{
    public partial class MeasurementTechnique1
    {
        public MeasurementTechnique1()
        {
            SiteMonitorParameter = new HashSet<SiteMonitorParameter>();
        }

        public int MeasurementTechniqueId { get; set; }
        public string MeasurementTechniqueCode { get; set; }
        public string MeasurementTechniqueDescription { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<SiteMonitorParameter> SiteMonitorParameter { get; set; }
    }
}

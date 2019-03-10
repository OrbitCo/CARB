using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class MeasurementTechnique1
    {
        public MeasurementTechnique1()
        {
            MonitorMfrModelParameterDetails = new HashSet<MonitorMfrModelParameterDetails>();
            SiteMonitorParameter = new HashSet<SiteMonitorParameter>();
        }

        public int MeasurementTechniqueId { get; set; }
        public int ParameterId { get; set; }
        public string ParameterCode { get; set; }
        public string MeasurementTechniqueCode { get; set; }
        public string MeasurementTechniqueDescription { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public Parameter Parameter { get; set; }
        public ICollection<MonitorMfrModelParameterDetails> MonitorMfrModelParameterDetails { get; set; }
        public ICollection<SiteMonitorParameter> SiteMonitorParameter { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class Parameter
    {
        public Parameter()
        {
            MeasurementTechnique1 = new HashSet<MeasurementTechnique1>();
            MonitorMfrModelParameter = new HashSet<MonitorMfrModelParameter>();
            SiteMonitorParameter = new HashSet<SiteMonitorParameter>();
        }

        public int ParameterId { get; set; }
        public string ParameterCode { get; set; }
        public string Parameter1 { get; set; }
        public string StandardUnits { get; set; }
        public string RoundOrTruncate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<MeasurementTechnique1> MeasurementTechnique1 { get; set; }
        public ICollection<MonitorMfrModelParameter> MonitorMfrModelParameter { get; set; }
        public ICollection<SiteMonitorParameter> SiteMonitorParameter { get; set; }
    }
}

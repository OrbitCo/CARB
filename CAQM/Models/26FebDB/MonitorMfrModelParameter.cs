using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class MonitorMfrModelParameter
    {
        public MonitorMfrModelParameter()
        {
            MonitorMfrModelParameterDetails = new HashSet<MonitorMfrModelParameterDetails>();
        }

        public int MonitorMfrModelParameterId { get; set; }
        public int MonitorMfrModelId { get; set; }
        public int ParameterId { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public MonitorMfrModel MonitorMfrModel { get; set; }
        public Parameter Parameter { get; set; }
        public ICollection<MonitorMfrModelParameterDetails> MonitorMfrModelParameterDetails { get; set; }
    }
}

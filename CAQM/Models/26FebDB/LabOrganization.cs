using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class LabOrganization
    {
        public LabOrganization()
        {
            MeasurementStreamData = new HashSet<MeasurementStreamData>();
        }

        public int LabOrganizationId { get; set; }
        public string LabOrganizationName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<MeasurementStreamData> MeasurementStreamData { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class AdjustmentTechnique
    {
        public AdjustmentTechnique()
        {
            MeasurementStreamData = new HashSet<MeasurementStreamData>();
        }

        public int AdjustmentTechniqueId { get; set; }
        public int DataProviderId { get; set; }
        public string AdjustmentCode { get; set; }
        public string AdjustmentDescription { get; set; }
        public int? InternalAdjustmentCode { get; set; }
        public string InternalAdjustmentCodeDescription { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public DataProvider1 DataProvider { get; set; }
        public ICollection<MeasurementStreamData> MeasurementStreamData { get; set; }
    }
}

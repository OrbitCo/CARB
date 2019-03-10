using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class Instrument
    {
        public Instrument()
        {
            SetupMetadata = new HashSet<SetupMetadata>();
        }

        public int InstrumentId { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int? MeasurementTechniqueCode { get; set; }
        public string ParameterCode { get; set; }
        public string StandardUnitsCode { get; set; }
        public string MonitorResolution { get; set; }
        public string UpperDetectionLimit { get; set; }
        public string LowerDetectionLimit { get; set; }
        public string MethodDetectionLimit { get; set; }
        public string DetectionRangeUnits { get; set; }
        public string Uncertainty { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<SetupMetadata> SetupMetadata { get; set; }
    }
}

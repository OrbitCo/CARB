using System;
using System.Collections.Generic;

namespace CAQM.Models.19FEB
{
    public partial class DistrictDataMeasurementFileArchive
    {
        public DistrictDataMeasurementFileArchive()
        {
            DistrictDataMeasurementStagingArchive = new HashSet<DistrictDataMeasurementStagingArchive>();
        }

        public int DistrictDataMeasurementFileId { get; set; }
        public string SubmittedFileName { get; set; }
        public byte[] SubmittedFile { get; set; }
        public DateTime ArchivedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<DistrictDataMeasurementStagingArchive> DistrictDataMeasurementStagingArchive { get; set; }
    }
}

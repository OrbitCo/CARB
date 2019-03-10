using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class MeasurementFile
    {
        public MeasurementFile()
        {
            MeasurementStaging = new HashSet<MeasurementStaging>();
            MeasurementStreamData = new HashSet<MeasurementStreamData>();
        }

        public int MeasurementFileId { get; set; }
        public string SubmittedFileName { get; set; }
        public byte[] SubmittedFile { get; set; }
        public bool? FileIsValid { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public User CreatedByNavigation { get; set; }
        public User UpdatedByNavigation { get; set; }
        public ICollection<MeasurementStaging> MeasurementStaging { get; set; }
        public ICollection<MeasurementStreamData> MeasurementStreamData { get; set; }
    }
}

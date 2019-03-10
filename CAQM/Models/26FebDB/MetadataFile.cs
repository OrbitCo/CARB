using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class MetadataFile
    {
        public MetadataFile()
        {
            MetadataStaging = new HashSet<MetadataStaging>();
        }

        public int MetadataFileId { get; set; }
        public string SubmittedFileName { get; set; }
        public byte[] SubmittedFile { get; set; }
        public bool? FileIsValid { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public User CreatedByNavigation { get; set; }
        public User UpdatedByNavigation { get; set; }
        public ICollection<MetadataStaging> MetadataStaging { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class MetadataFileArchive
    {
        public MetadataFileArchive()
        {
            MetadataStagingArchive = new HashSet<MetadataStagingArchive>();
        }

        public int MetadataFileId { get; set; }
        public string SubmittedFileName { get; set; }
        public byte[] SubmittedFile { get; set; }
        public DateTime ArchivedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<MetadataStagingArchive> MetadataStagingArchive { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace CAQM.Models.19FEB
{
    public partial class DistrictDataMetadataFileArchive
    {
        public DistrictDataMetadataFileArchive()
        {
            DistrictDataMetadataStagingArchive = new HashSet<DistrictDataMetadataStagingArchive>();
        }

        public int DistrictDataMetadataFileId { get; set; }
        public string SubmittedFileName { get; set; }
        public byte[] SubmittedFile { get; set; }
        public DateTime ArchivedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<DistrictDataMetadataStagingArchive> DistrictDataMetadataStagingArchive { get; set; }
    }
}

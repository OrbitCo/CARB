using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class DataFileArchive
    {
        public long DataFileId { get; set; }
        public string SubmittedFileName { get; set; }
        public byte[] SubmittedFile { get; set; }
        public DateTime? ArchivedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
    }
}

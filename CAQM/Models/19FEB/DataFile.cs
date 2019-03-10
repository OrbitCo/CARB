using System;
using System.Collections.Generic;

namespace CAQM.Models.19FEB
{
    public partial class DataFile
    {
        public DataFile()
        {
            SetupMetadata = new HashSet<SetupMetadata>();
        }

        public int DataFileId { get; set; }
        public string SubmittedFileName { get; set; }
        public byte[] SubmittedFile { get; set; }
        public bool FileIsLoaded { get; set; }
        public string LoadingErrors { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public ICollection<SetupMetadata> SetupMetadata { get; set; }
    }
}

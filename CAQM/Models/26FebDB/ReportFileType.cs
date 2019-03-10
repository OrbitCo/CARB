using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class ReportFileType
    {
        public ReportFileType()
        {
            ReportFile = new HashSet<ReportFile>();
        }

        public int ReportFileTypeId { get; set; }
        public string ReportFileType1 { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<ReportFile> ReportFile { get; set; }
    }
}

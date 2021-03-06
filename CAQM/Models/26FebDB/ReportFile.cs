﻿using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class ReportFile
    {
        public int ReportFileId { get; set; }
        public int ReportFileTypeId { get; set; }
        public string SubmittedFileName { get; set; }
        public byte[] SubmittedFile { get; set; }
        public bool? FileIsValid { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ReportFileType ReportFileType { get; set; }
    }
}

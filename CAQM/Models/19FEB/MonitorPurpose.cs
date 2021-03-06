﻿using System;
using System.Collections.Generic;

namespace CAQM.Models.19FEB
{
    public partial class MonitorPurpose
    {
        public MonitorPurpose()
        {
            SetupMetadata = new HashSet<SetupMetadata>();
        }

        public int MonitorPurposeId { get; set; }
        public int MonitorPurposeCode { get; set; }
        public string MonitorPurpose1 { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<SetupMetadata> SetupMetadata { get; set; }
    }
}

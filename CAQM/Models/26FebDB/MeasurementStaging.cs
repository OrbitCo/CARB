﻿using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class MeasurementStaging
    {
        public int MeasurementFileId { get; set; }
        public int RecordId { get; set; }
        public string SiteId { get; set; }
        public string MonitorId { get; set; }
        public string Parameter { get; set; }
        public string MethodDetectionLimit { get; set; }
        public string DetectionRangeUnit { get; set; }
        public string LabOrganization { get; set; }
        public string MeasurementDate { get; set; }
        public string MeasurementStartTime { get; set; }
        public string ChannelAmeasurementValue { get; set; }
        public string ChannelBmeasurementValue { get; set; }
        public string ChannelCmeasurementValue { get; set; }
        public string MeasurementUnit { get; set; }
        public string ChannelAadjustedMeasurementValue { get; set; }
        public string ChannelBadjustedMeasurementValue { get; set; }
        public string ChannelCadjustedMeasurementValue { get; set; }
        public string AdjustmentTechnique { get; set; }
        public string Uncertainty { get; set; }
        public string Quality { get; set; }
        public bool? RecordIsValid { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool? IsApproved { get; set; }
        public int? ApprovedBy { get; set; }

        public User CreatedByNavigation { get; set; }
        public MeasurementFile MeasurementFile { get; set; }
        public User UpdatedByNavigation { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;

namespace CAQM.Models.19FEB
{
    public partial class DistrictDataMetadataStagingArchive
    {
        public int DistrictDataMetadataFileId { get; set; }
        public int RecordId { get; set; }
        public string TransactionType { get; set; }
        public string CommunityProjectName { get; set; }
        public string SiteName { get; set; }
        public string SiteId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Elevation { get; set; }
        public string Cfrsiting { get; set; }
        public string MonitorPurpose { get; set; }
        public string MonitorId { get; set; }
        public string ChannelAid { get; set; }
        public string ChannelBid { get; set; }
        public string ChannelCid { get; set; }
        public string MonitorManufacturer { get; set; }
        public string MonitorModel { get; set; }
        public string FirmwareVersion { get; set; }
        public string Parameter { get; set; }
        public string MeasurementTechnique { get; set; }
        public string SamplingFrequency { get; set; }
        public string SamplingDuration { get; set; }
        public string UpperDetectionLimit { get; set; }
        public string LowerDetectionLimit { get; set; }
        public string MethodDetectionLimit { get; set; }
        public string DetectionRangeUnits { get; set; }
        public string MonitorUncertainty { get; set; }
        public string MeasurementPrecision { get; set; }
        public string SystemDescription { get; set; }
        public string MonitorPurchaseDate { get; set; }
        public string LastCalibrationTimestamp { get; set; }
        public string LastServiceDate { get; set; }
        public string InletOrientation { get; set; }
        public string InletHeight { get; set; }
        public string InletDiameter { get; set; }
        public string FlowRate { get; set; }
        public string MeasurementResolution { get; set; }
        public string Explanation { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool? RecordIsValid { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool? IsApproved { get; set; }
        public int? ApprovedBy { get; set; }

        public DistrictDataMetadataFileArchive DistrictDataMetadataFile { get; set; }
    }
}

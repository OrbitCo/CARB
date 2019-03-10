using System;
using System.Collections.Generic;

namespace CAQM.Models.19FEB
{
    public partial class SetupMetadata
    {
        public int DataFileId { get; set; }
        public long SetupMetadataId { get; set; }
        public int? TransactionTypeId { get; set; }
        public int? CommunityId { get; set; }
        public string SiteName { get; set; }
        public string SiteId { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
        public double? Elevation { get; set; }
        public int? Cfrsiting { get; set; }
        public int? MonitorPurposeId { get; set; }
        public int DataProviderId { get; set; }
        public string SensorId { get; set; }
        public int? InstrumentId { get; set; }
        public string MonitorModel { get; set; }
        public string FirmwareVersion { get; set; }
        public int? ParameterId { get; set; }
        public string MeasurementTechnique { get; set; }
        public string SamplingFrequency { get; set; }
        public int? SampleDurationId { get; set; }
        public double? UpperDetectionLimit { get; set; }
        public double? LowerDetectionLimit { get; set; }
        public double? MethodDetectionLimit { get; set; }
        public string DetectionRangeUnits { get; set; }
        public string MonitorUncertainty { get; set; }
        public string MonitorPrecision { get; set; }
        public string SystemDescription { get; set; }
        public int? MonitorPurchaseDate { get; set; }
        public DateTime? LastCalibrationTimestamp { get; set; }
        public int? LastServiceDate { get; set; }
        public int? InletOrientation { get; set; }
        public double? InletHeight { get; set; }
        public double? InletDiameter { get; set; }
        public string FlowRate { get; set; }
        public int? MeasurementResolution { get; set; }
        public string Explanation { get; set; }
        public int? EffectiveDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string IsApproved { get; set; }
        public int? ApprovedBy { get; set; }

        public Community Community { get; set; }
        public User CreatedByNavigation { get; set; }
        public DataFile DataFile { get; set; }
        public DataProvider DataProvider { get; set; }
        public Instrument Instrument { get; set; }
        public MonitorPurpose MonitorPurpose { get; set; }
        public Parameter Parameter { get; set; }
        public SampleDuration SampleDuration { get; set; }
        public TransactionType TransactionType { get; set; }
    }
}

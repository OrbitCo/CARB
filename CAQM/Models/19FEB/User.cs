using System;
using System.Collections.Generic;

namespace CAQM.Models.19FEB
{
    public partial class User
    {
        public User()
        {
            ActivityLog = new HashSet<ActivityLog>();
            DistrictDataMeasurementFileCreatedByNavigation = new HashSet<DistrictDataMeasurementFile>();
            DistrictDataMeasurementFileUpdatedByNavigation = new HashSet<DistrictDataMeasurementFile>();
            DistrictDataMeasurementStagingCreatedByNavigation = new HashSet<DistrictDataMeasurementStaging>();
            DistrictDataMeasurementStagingUpdatedByNavigation = new HashSet<DistrictDataMeasurementStaging>();
            DistrictDataMetadataFileCreatedByNavigation = new HashSet<DistrictDataMetadataFile>();
            DistrictDataMetadataFileUpdatedByNavigation = new HashSet<DistrictDataMetadataFile>();
            DistrictDataMetadataStagingCreatedByNavigation = new HashSet<DistrictDataMetadataStaging>();
            DistrictDataMetadataStagingUpdatedByNavigation = new HashSet<DistrictDataMetadataStaging>();
            MonitorStagingCreatedByNavigation = new HashSet<MonitorStaging>();
            MonitorStagingUpdatedByNavigation = new HashSet<MonitorStaging>();
            Notification = new HashSet<Notification>();
            Privilege = new HashSet<Privilege>();
            SetupMetadata = new HashSet<SetupMetadata>();
            SiteData = new HashSet<SiteData>();
            TimeSeriesCreatedByNavigation = new HashSet<TimeSeries>();
            TimeSeriesStagingCreatedByNavigation = new HashSet<TimeSeriesStaging>();
            TimeSeriesStagingUpdatedByNavigation = new HashSet<TimeSeriesStaging>();
            TimeSeriesUpdatedByNavigation = new HashSet<TimeSeries>();
            UserDocument = new HashSet<UserDocument>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        public string Username { get; set; }
        public int RoleId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int? PhoneTypeId { get; set; }
        public int? UserTypeId { get; set; }
        public int? AirDistrictId { get; set; }
        public int? CarbDivisionId { get; set; }
        public int? AccessLevelId { get; set; }
        public string Rationale { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public AccessLevel AccessLevel { get; set; }
        public AirDistrict AirDistrict { get; set; }
        public CarbDivision CarbDivision { get; set; }
        public PhoneType PhoneType { get; set; }
        public Role Role { get; set; }
        public UserType UserType { get; set; }
        public ICollection<ActivityLog> ActivityLog { get; set; }
        public ICollection<DistrictDataMeasurementFile> DistrictDataMeasurementFileCreatedByNavigation { get; set; }
        public ICollection<DistrictDataMeasurementFile> DistrictDataMeasurementFileUpdatedByNavigation { get; set; }
        public ICollection<DistrictDataMeasurementStaging> DistrictDataMeasurementStagingCreatedByNavigation { get; set; }
        public ICollection<DistrictDataMeasurementStaging> DistrictDataMeasurementStagingUpdatedByNavigation { get; set; }
        public ICollection<DistrictDataMetadataFile> DistrictDataMetadataFileCreatedByNavigation { get; set; }
        public ICollection<DistrictDataMetadataFile> DistrictDataMetadataFileUpdatedByNavigation { get; set; }
        public ICollection<DistrictDataMetadataStaging> DistrictDataMetadataStagingCreatedByNavigation { get; set; }
        public ICollection<DistrictDataMetadataStaging> DistrictDataMetadataStagingUpdatedByNavigation { get; set; }
        public ICollection<MonitorStaging> MonitorStagingCreatedByNavigation { get; set; }
        public ICollection<MonitorStaging> MonitorStagingUpdatedByNavigation { get; set; }
        public ICollection<Notification> Notification { get; set; }
        public ICollection<Privilege> Privilege { get; set; }
        public ICollection<SetupMetadata> SetupMetadata { get; set; }
        public ICollection<SiteData> SiteData { get; set; }
        public ICollection<TimeSeries> TimeSeriesCreatedByNavigation { get; set; }
        public ICollection<TimeSeriesStaging> TimeSeriesStagingCreatedByNavigation { get; set; }
        public ICollection<TimeSeriesStaging> TimeSeriesStagingUpdatedByNavigation { get; set; }
        public ICollection<TimeSeries> TimeSeriesUpdatedByNavigation { get; set; }
        public ICollection<UserDocument> UserDocument { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class User
    {
        public User()
        {
            ActivityLog1 = new HashSet<ActivityLog1>();
            MeasurementFileCreatedByNavigation = new HashSet<MeasurementFile>();
            MeasurementFileUpdatedByNavigation = new HashSet<MeasurementFile>();
            MeasurementStagingCreatedByNavigation = new HashSet<MeasurementStaging>();
            MeasurementStagingUpdatedByNavigation = new HashSet<MeasurementStaging>();
            MetadataFileCreatedByNavigation = new HashSet<MetadataFile>();
            MetadataFileUpdatedByNavigation = new HashSet<MetadataFile>();
            MetadataStagingCreatedByNavigation = new HashSet<MetadataStaging>();
            MetadataStagingUpdatedByNavigation = new HashSet<MetadataStaging>();
            Notification = new HashSet<Notification>();
            Privilege = new HashSet<Privilege>();
            UserDataProvider = new HashSet<UserDataProvider>();
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

        public AccessLevel1 AccessLevel { get; set; }
        public AirDistrict1 AirDistrict { get; set; }
        public CarbDivision1 CarbDivision { get; set; }
        public PhoneType PhoneType { get; set; }
        public Role Role { get; set; }
        public UserType UserType { get; set; }
        public ICollection<ActivityLog1> ActivityLog1 { get; set; }
        public ICollection<MeasurementFile> MeasurementFileCreatedByNavigation { get; set; }
        public ICollection<MeasurementFile> MeasurementFileUpdatedByNavigation { get; set; }
        public ICollection<MeasurementStaging> MeasurementStagingCreatedByNavigation { get; set; }
        public ICollection<MeasurementStaging> MeasurementStagingUpdatedByNavigation { get; set; }
        public ICollection<MetadataFile> MetadataFileCreatedByNavigation { get; set; }
        public ICollection<MetadataFile> MetadataFileUpdatedByNavigation { get; set; }
        public ICollection<MetadataStaging> MetadataStagingCreatedByNavigation { get; set; }
        public ICollection<MetadataStaging> MetadataStagingUpdatedByNavigation { get; set; }
        public ICollection<Notification> Notification { get; set; }
        public ICollection<Privilege> Privilege { get; set; }
        public ICollection<UserDataProvider> UserDataProvider { get; set; }
        public ICollection<UserDocument> UserDocument { get; set; }
    }
}

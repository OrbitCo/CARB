using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class User1
    {
        public User1()
        {
            ActivityLog = new HashSet<ActivityLog>();
            MonitorStagingCreatedByNavigation = new HashSet<MonitorStaging>();
            MonitorStagingUpdatedByNavigation = new HashSet<MonitorStaging>();
            Notification1 = new HashSet<Notification1>();
            Privilege1 = new HashSet<Privilege1>();
            SetupMetadata = new HashSet<SetupMetadata>();
            TimeSeriesStagingCreatedByNavigation = new HashSet<TimeSeriesStaging>();
            TimeSeriesStagingUpdatedByNavigation = new HashSet<TimeSeriesStaging>();
            UserDocument1 = new HashSet<UserDocument1>();
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
        public PhoneType1 PhoneType { get; set; }
        public Role1 Role { get; set; }
        public UserType1 UserType { get; set; }
        public ICollection<ActivityLog> ActivityLog { get; set; }
        public ICollection<MonitorStaging> MonitorStagingCreatedByNavigation { get; set; }
        public ICollection<MonitorStaging> MonitorStagingUpdatedByNavigation { get; set; }
        public ICollection<Notification1> Notification1 { get; set; }
        public ICollection<Privilege1> Privilege1 { get; set; }
        public ICollection<SetupMetadata> SetupMetadata { get; set; }
        public ICollection<TimeSeriesStaging> TimeSeriesStagingCreatedByNavigation { get; set; }
        public ICollection<TimeSeriesStaging> TimeSeriesStagingUpdatedByNavigation { get; set; }
        public ICollection<UserDocument1> UserDocument1 { get; set; }
    }
}

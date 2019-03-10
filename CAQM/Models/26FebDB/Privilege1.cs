using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class Privilege1
    {
        public int PrivilegeId { get; set; }
        public int UserId { get; set; }
        public bool BuildAdHocQueries { get; set; }
        public bool BuildAdHovReports { get; set; }
        public bool ConfigureAttributes { get; set; }
        public bool ConfigurePrivileges { get; set; }
        public bool ConfigureRoles { get; set; }
        public bool CreateUser { get; set; }
        public bool DeactivateReactivateUser { get; set; }
        public bool DeleteData { get; set; }
        public bool DeleteUser { get; set; }
        public bool ProvisionUserAccount { get; set; }
        public bool RunCannedQueries { get; set; }
        public bool RunCannedReports { get; set; }
        public bool SaveAdHocQueries { get; set; }
        public bool SaveAdHovReports { get; set; }
        public bool UpdateData { get; set; }
        public bool UpdateUser { get; set; }
        public bool UploadData { get; set; }
        public bool ViewAllData { get; set; }
        public bool ViewAllDataConstrained { get; set; }
        public bool ViewEmissionsData { get; set; }
        public bool ViewPublicData { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public User1 User { get; set; }
    }
}

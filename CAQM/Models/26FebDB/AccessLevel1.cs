using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class AccessLevel1
    {
        public AccessLevel1()
        {
            User = new HashSet<User>();
        }

        public int AccessLevelId { get; set; }
        public string AccessLevelName { get; set; }
        public string AccessLevelDescription { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<User> User { get; set; }
    }
}

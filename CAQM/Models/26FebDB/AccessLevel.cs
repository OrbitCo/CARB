using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class AccessLevel
    {
        public AccessLevel()
        {
            User1 = new HashSet<User1>();
        }

        public int AccessLevelId { get; set; }
        public string AccessLevelName { get; set; }
        public string AccessLevelDescription { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<User1> User1 { get; set; }
    }
}

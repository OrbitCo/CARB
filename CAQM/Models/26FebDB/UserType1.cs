using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class UserType1
    {
        public UserType1()
        {
            User1 = new HashSet<User1>();
        }

        public int UserTypeId { get; set; }
        public string UserTypeName { get; set; }
        public bool SubType { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<User1> User1 { get; set; }
    }
}

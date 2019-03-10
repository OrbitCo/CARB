using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class Role1
    {
        public Role1()
        {
            User1 = new HashSet<User1>();
        }

        public int RoleId { get; set; }
        public string Role { get; set; }
        public string RoleDescription { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<User1> User1 { get; set; }
    }
}

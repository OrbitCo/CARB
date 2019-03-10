using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class PhoneType
    {
        public PhoneType()
        {
            User = new HashSet<User>();
        }

        public int PhoneTypeId { get; set; }
        public string PhoneType1 { get; set; }
        public string PhoneTypeDescription { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<User> User { get; set; }
    }
}

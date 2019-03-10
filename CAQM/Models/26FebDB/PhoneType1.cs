using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class PhoneType1
    {
        public PhoneType1()
        {
            User1 = new HashSet<User1>();
        }

        public int PhoneTypeId { get; set; }
        public string PhoneType { get; set; }
        public string PhoneTypeDescription { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<User1> User1 { get; set; }
    }
}

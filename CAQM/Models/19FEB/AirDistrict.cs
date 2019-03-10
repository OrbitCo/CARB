using System;
using System.Collections.Generic;

namespace CAQM.Models.19FEB
{
    public partial class AirDistrict
    {
        public AirDistrict()
        {
            User = new HashSet<User>();
        }

        public int AirDistrictId { get; set; }
        public string AirDistrictName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<User> User { get; set; }
    }
}

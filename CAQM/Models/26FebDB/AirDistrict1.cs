﻿using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class AirDistrict1
    {
        public AirDistrict1()
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

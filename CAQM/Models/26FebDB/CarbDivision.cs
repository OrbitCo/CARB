using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class CarbDivision
    {
        public CarbDivision()
        {
            User1 = new HashSet<User1>();
        }

        public int CarbDivisionId { get; set; }
        public string CarbDivisionName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<User1> User1 { get; set; }
    }
}

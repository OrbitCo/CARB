using System;
using System.Collections.Generic;

namespace CAQM.Models.19FEB
{
    public partial class CarbDivision
    {
        public CarbDivision()
        {
            User = new HashSet<User>();
        }

        public int CarbDivisionId { get; set; }
        public string CarbDivisionName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<User> User { get; set; }
    }
}

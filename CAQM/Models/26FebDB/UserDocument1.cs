using System;
using System.Collections.Generic;

namespace CAQM.Models.26FebDB
{
    public partial class UserDocument1
    {
        public int UserDocumentId { get; set; }
        public int UserId { get; set; }
        public string FileName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public User1 User { get; set; }
    }
}

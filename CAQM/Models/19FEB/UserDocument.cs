using System;
using System.Collections.Generic;

namespace CAQM.Models.19FEB
{
    public partial class UserDocument
    {
        public int UserDocumentId { get; set; }
        public int UserId { get; set; }
        public string FileName { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public User User { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace CAQM.Models.19FEB
{
    public partial class TransactionType
    {
        public TransactionType()
        {
            SetupMetadata = new HashSet<SetupMetadata>();
        }

        public int TransactionTypeId { get; set; }
        public string TransactionTypeCode { get; set; }
        public string TransactionTypeDefinition { get; set; }
        public string Comment { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        public ICollection<SetupMetadata> SetupMetadata { get; set; }
    }
}

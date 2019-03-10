using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace CAQM.Entities
{
    public class DataFile
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DataFileId { get; set; }
        public string SubmittedFileName { get; set; }
        public string SubmittedFile { get; set; }
        public Boolean FileIsLoaded { get; set; }
        public string LoadingErrors { get; set; }
        
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }

        //public virtual int UserId { get; set; }
        //[ForeignKey("UserId")]
        //public virtual User User { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CAQM.Entities
{
    public class ActivityLog
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string IdNumber { get; set; }
        public string DataType { get; set; }
        public string ActionType { get; set; }
        public bool IsWrongSigninAttempt { get; set; }
        
        //public int CategoryId { get; set; } //there must be a category table        
        public DateTime CreatedDate { get; set; }

        public virtual int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}

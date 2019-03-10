using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace CAQM.Entities
{
    public class FileData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string FacilityID { get; set; }
        public string FlowAmount { get; set; }
        public string FlowName { get; set; }
        public string Compartment { get; set; }
        public string Reliability { get; set; }
        public string Source { get; set; }
        public string Year { get; set; }
        public string FRS_ID { get; set; }
        public string SRS_CAS { get; set; }
        public string SRS_ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }


        public virtual int UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}

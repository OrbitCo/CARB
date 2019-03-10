using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CAQM.Entities
{
    public class SiteData
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public bool Active { get; set; }

      
        public string SiteId { get; set; }
        public string Elevation { get; set; }
        public string SiteName { get; set; }
        public string CommunityProjectName { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }

        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string Explanation { get; set; }
        public DateTime? RelocationStartDate { get; set; }
        public DateTime? RelocationEndDate { get; set; }
        public DateTime? DeactivationEndDate { get; set; }

        public  int UserId { get; set; }

      

    }
}

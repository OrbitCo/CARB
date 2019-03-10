using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CAQM.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }

        // Add New Property for User Roles
        //public string UserRole { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public string Email { get; set; }
        public string Phone { get; set; }
        //public string Position { get; set; }


        public int PhoneTypeId { get; set; }
        public int UserTypeId { get; set; }
        public int AirDistrictId { get; set; }
        public int CarbDivisionId { get; set; }
        public int AccessLevelId { get; set; }


        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }

        public virtual int RoleId { get; set; }

        [ForeignKey("RoleId")]
        public virtual Roles Roles { get; set; }
    }
}


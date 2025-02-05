using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elearnin.Models
{
    public enum UserRole
    {
        Student,
        Admin,
        Instructor
    }
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required, MaxLength(50)]
        public string FullName { get; set; }

        [Required, MaxLength(100)]
        public string Email { get; set; }

        [Required, MinLength(7), MaxLength(20)]
        public string Password { get; set; }

        
        public int ?Age { get; set; }

        [ MaxLength(12)]
        public string? Phone { get; set; }

        [Required]
        [EnumDataType(typeof(UserRole))]
        
        public UserRole Role { get; set; }
        
        
        

        public virtual List<Subscribe>? corses { get; set; }
    }
}

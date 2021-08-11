using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Service.Dto
{
    public class RegisterDto
    {
        [Required] public string Username { get; set; }
        [Required] public string KnownAs { get; set; }
        [Required] public string Gender { get; set; }
        [Required] public string Email { get; set; }
        [Required] public DateTime DateOfBirth { get; set; }
        [Required] public int City { get; set; }
        [Required] public int State { get; set; }
        [Required] public int Country { get; set; }
        [Required] public string Role { get; set; }
        public string ReportedBy { get; set; }
        public string CreatedBy { get; set; }
        [Required]
        [StringLength(8, MinimumLength = 4)]
        public string Password { get; set; }
    }
}

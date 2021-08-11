using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace Service.Entities
{
    public class AppUser : IdentityUser<int>
    {
        public string KnownAs { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ReportedBy { get; set; }
        public string CreatedBy { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public ICollection<AppUserRole> UserRoles { get; set; }
    }
}

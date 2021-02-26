using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SecuringApps_WebApplication.Data
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        public string Address { get; set; }
        public string RecoveryEmail { get; set; }
    }
}

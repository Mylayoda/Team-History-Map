using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityCustomisationTest.Areas.Identity.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string CustomTag { get; set; }
        //public DateTime DateOfBirth { get; set; }
    }
}

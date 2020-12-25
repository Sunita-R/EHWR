using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EHWR.API.Models
{
    public class AppIdentityRole : IdentityRole
    { }

    public class AppIdentityUser : IdentityUser
    {
        public int Age { get; set; }
    }

}

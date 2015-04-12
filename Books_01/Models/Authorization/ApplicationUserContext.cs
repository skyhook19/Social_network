using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Books_01.Models.Authorization
{
    public class ApplicationUserContext : IdentityDbContext<ApplicationUser, AppRole, int, AppUserLogin, AppUserRole, AppUserClaim>
    {
        public ApplicationUserContext() : base("DefaultConnection")
        {
        }
    }
}
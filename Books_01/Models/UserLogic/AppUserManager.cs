using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Books_01.Models.UserLogic
{
    public class AppUserManager : UserManager<ApplicationUser, int>
    {
        public AppUserManager(IAppUserStore store) : base(store)
        {
        }
    }
}
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Books_01.Models.UserLogic
{
    public interface IAppUserStore : IUserStore<ApplicationUser, int>
    {

    }

    public class AppUserStore : UserStore<ApplicationUser, AppRole, int, AppUserLogin, AppUserRole, AppUserClaim>, IAppUserStore
    {
        public AppUserStore() : base(new ApplicationUserContext())
        {
        }

        public AppUserStore(ApplicationUserContext context) : base(context)
        {
        }
    }
}
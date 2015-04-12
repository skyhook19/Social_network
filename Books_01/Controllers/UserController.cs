using Books_01.Models.UserLogic;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Books_01.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        //
        // GET: /User/

        private AppUserManager UserManager = new AppUserManager(new AppUserStore(new ApplicationUserContext()));


        public async Task<ActionResult> Index(int? id)
        {
            if (id != null)
            {
                var user = await UserManager.FindByIdAsync(id.Value);
                if (user == null)
                {
                    return HttpNotFound("User does not exist");
                }
                return View(model: user);
            }
            return HttpNotFound();
        }
	}
}
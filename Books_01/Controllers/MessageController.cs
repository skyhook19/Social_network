using Books_01.Models.Message;
using Books_01.Models.UserLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Books_01.Controllers
{
    [Authorize]
    public class MessageController : Controller
    {

        private AppUserManager UserManager = new AppUserManager(new AppUserStore(new ApplicationUserContext()));

        //
        // GET: /Message/
        public async Task<ActionResult> Index(int id)
        {
            var user = await UserManager.FindByIdAsync(id);
            if (user == null)
            {
                return HttpNotFound("User does not exist");
            }

            ICollection<Message> messages;
            using (MessageContext context = new MessageContext())
            {
                 messages = (from item in context.Messages where item.RecipientId == id select item).ToList<Message>();
            }

            return View(model: messages);
        }
	}
}
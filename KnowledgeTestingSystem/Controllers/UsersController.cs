using BLL.Interfaces;
using DAL.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin.Security;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace KnowledgeTestingSystem.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsersService _usersService;

        public UsersController(IUsersService usersService)
        {
            _usersService = usersService;
        }

        // GET: User\SignUp
        [HttpGet]
        public async Task<ActionResult> SignUp()
        {
            return View(new User());
        }

        [HttpPost]
        public async Task<ActionResult> SignUp(User user)
        {
            try
            {
                await _usersService.CreateAsync(user);
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View(new User());
            }
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View(new User());
        }

        [HttpPost]
        public async Task<ActionResult> Login(User user)
        {
            var userStore = new UserStore<IdentityUser>();
            var manager = new UserManager<IdentityUser>(userStore);
            var userFind = await _usersService.GetIdentityUserAsync(user);

            if (userFind != null)
            {
                var authenticationManager = HttpContext.GetOwinContext().Authentication;
                var userIdentity = manager.CreateIdentity(userFind, DefaultAuthenticationTypes.ApplicationCookie);

                authenticationManager.SignIn(new AuthenticationProperties() { IsPersistent = false }, userIdentity);
            }
            else
            {

            }
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public ActionResult SignOut()
        {
            var authenticationManager = HttpContext.GetOwinContext().Authentication;
            authenticationManager.SignOut();

            return RedirectToAction("Index", "Home");
        }
    }
}
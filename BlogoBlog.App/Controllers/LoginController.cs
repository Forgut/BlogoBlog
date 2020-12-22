using BlogoBlog.App.Models.Login;
using BlogoBlog.Logic.Enums;
using BlogoBlog.Logic.Services;
using System.Web.Mvc;

namespace BlogoBlog.App.Controllers
{
    public class LoginController : BaseController
    {
        [HttpGet]
        public ActionResult Login()
        {
            var model = new LoginViewModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model)
        {
            var result = new RegistrationService().Login(model.Login, model.Password);
            if (result == ELoginResult.OK)
            {
                new CookieService(Response).AddUserCookie(model.Login);
                return RedirectToAction("Index", "Home");
            }
            CreateErrorMessage(l10n.Translation.LoginErrorMessage);
            return View(model);
        }
    }
}
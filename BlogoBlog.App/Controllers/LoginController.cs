using BlogoBlog.App.Models.Login;
using BlogoBlog.Logic.Enums;
using BlogoBlog.Logic.Providers;
using BlogoBlog.Logic.Registration;
using BlogoBlog.Logic.Services;
using System.Web.Mvc;
using DryIoc;

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
                new CookieService(HttpContext.Request, HttpContext.Response).AddUserCookie(model.Login);
                return RedirectToAction("Index", "Home");
            }
            CreateErrorMessage(l10n.Translation.LoginErrorMessage);
            return View(model);
        }

        /// <summary>
        /// should be done by post TODO
        /// </summary>
        [HttpGet]
        public ActionResult Logout()
        {
            new CookieService(Request, Response).RemoveLoggedUserCookie();
            return RedirectToAction("Index", "Home");
        }
    }
}
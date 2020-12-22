using BlogoBlog.App.Models.Login;
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
            if (model.Login == "admin" && model.Password == "password")
                return RedirectToAction("Index", "Home");
            CreateErrorMessage(l10n.Translation.LoginErrorMessage);
            return View(model);
        }
    }
}
using BlogoBlog.App.Models.Registration;
using BlogoBlog.Logic.Enums;
using BlogoBlog.Logic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogoBlog.App.Controllers
{
    public class RegistrationController : BaseController
    {
        [HttpGet]
        public ActionResult Register()
        {
            return View(new RegistrationViewModel());
        }

        [HttpPost]
        public ActionResult Register(RegistrationViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);
            
            if (model.Password != model.PasswordRepeated)
            {
                CreateErrorMessage(l10n.Translation.PasswordsMustBeEqual);
                return View(model);
            }

            var service = new RegistrationService();
            var result = service.Register(model.Email, model.Password, model.Username, model.IsBlogger);
            if (result != ERegistrationResponse.OK)
            {
                CreateErrorMessage(result.ToString());
                return View(model);
            }
            new CookieService(HttpContext.Request, HttpContext.Response).AddUserCookie(model.Username);
            Database.Db.Save();
            return RedirectToAction("Index", "Home");
        }
    }
}
using BlogoBlog.App.Models.User;
using BlogoBlog.Database;
using BlogoBlog.Logic.Enums;
using BlogoBlog.Logic.Providers;
using BlogoBlog.Logic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogoBlog.App.Controllers
{
    public class UserController : BaseController
    {
        public ActionResult Index()
        {
            var user = GetLoggedUser();
            var model = new UserViewModel()
            {
                Email = user.Email,
                Username = user.Name,
                UserType = (EUserType)user.Type
            };
            return View(model);
        }
        [HttpGet]
        public ActionResult UpgradeType()
        {
            var user = GetLoggedUser();
            user.Type = (int)EUserType.Blogger;
            Db.Save();
            return RedirectToAction("Index");
        }
    }
}
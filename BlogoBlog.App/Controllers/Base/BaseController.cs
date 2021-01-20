using BlogoBlog.Database;
using BlogoBlog.Logic.Providers;
using BlogoBlog.Logic.Registration;
using BlogoBlog.Logic.Services;
using System.Web.Mvc;
using DryIoc;

namespace BlogoBlog.App.Controllers
{
    public abstract class BaseController : Controller
    {
        public void CreateErrorMessage(string message)
        {
            ViewBag.ErrorMessage = message;
        }

        public User GetLoggedUser()
        {
            var service = new CookieService(HttpContext.Request, HttpContext.Response);
            var userProvider = IoC.Container.Resolve<UserProvider>();
            var loggedUserCookie = service.GetLoggedUserCookie();
            return userProvider.GetUser(loggedUserCookie.Value);
        }
    }
}
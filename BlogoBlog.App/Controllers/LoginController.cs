using BlogoBlog.App.Models.Login;
using System.Web.Mvc;

namespace BlogoBlog.App.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Index()
        {
            var model = new LoginViewModel();
            return View(model);
        }
    }
}
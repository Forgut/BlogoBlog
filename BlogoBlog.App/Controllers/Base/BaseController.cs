using System.Web.Mvc;

namespace BlogoBlog.App.Controllers
{
    public abstract class BaseController : Controller
    {
        public void CreateErrorMessage(string message)
        {
            ViewBag.ErrorMessage = message;
        }
    }
}
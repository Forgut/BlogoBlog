using System.Linq;
using System.Web.Mvc;

namespace BlogoBlog.App.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
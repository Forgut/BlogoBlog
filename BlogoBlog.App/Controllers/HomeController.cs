using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web.Mvc;

namespace BlogoBlog.App.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-EN");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-EN");
            return View();
        }
    }
}
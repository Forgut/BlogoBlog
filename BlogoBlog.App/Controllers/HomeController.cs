using BlogoBlog.App.Models.Home;
using BlogoBlog.Logic.Enums;
using BlogoBlog.Logic.Providers;
using System;
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
            var provider = new BlogProvider();
            var blogs = provider.GetBlogs()
                .Select(x => new Models.Blog.BlogViewModel()
                {
                    Name = x.BlogName,
                    ID = x.Id,
                    Author = x.User.Name
                })
                .ToList();
            var model = new HomeViewModel()
            {
                Blogs = blogs,
                CanCreateBlogs = GetLoggedUser()?.Type > (int)EUserType.Reader
            };
            return View(model);
        }
    }

}
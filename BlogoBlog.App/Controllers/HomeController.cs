using BlogoBlog.App.Models.Home;
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
                })
                .ToList();
            foreach (var blog in blogs)
                blog.Color = GetRandomColor();
            var model = new HomeViewModel()
            {
                Blogs = blogs
            };
            return View(model);
        }

        private string GetRandomColor()
        {
            var rand = new Random().Next(4);
            switch (rand)
            {
                case 0:
                    return "yellow";
                case 1:
                    return "red";
                case 2:
                    return "blue";
                case 3:
                    return "green";
                default:
                    return "white";
            }
        }
    }

}
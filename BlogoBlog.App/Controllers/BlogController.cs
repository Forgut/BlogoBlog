using BlogoBlog.App.Models.Blog;
using BlogoBlog.Logic.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BlogoBlog.App.Controllers
{
    public class BlogController : Controller
    {
        public ActionResult Index(int id)
        {
            var provider = new BlogProvider();
            var blog = provider.GetBlog(id);
            var model = new BlogViewModel()
            {
                ID = id,
                Name = blog.BlogName
            };
            return View(model);
        }
    }
}
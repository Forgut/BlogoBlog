using BlogoBlog.App.Models.Blog;
using BlogoBlog.Logic.Providers;
using BlogoBlog.Logic.Services;
using System.Web.Mvc;

namespace BlogoBlog.App.Controllers
{
    public class BlogController : BaseController
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

        public ActionResult Create()
        {
            var model = new BlogViewModel();
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(BlogViewModel model)
        {
            var service = new BlogService();
            var result = service.Create(model.Name);
            if (result == Logic.Enums.EBlogCreationResponse.NameNotUnique)
            {
                CreateErrorMessage(l10n.Translation.NameNotUnique);
                return View(model);
            }
            Database.Database.Save();
            return RedirectToAction("Index", "Home");
        }
    }
}
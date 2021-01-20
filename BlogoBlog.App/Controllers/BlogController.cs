using BlogoBlog.App.Models.Blog;
using BlogoBlog.App.Models.Post;
using BlogoBlog.Database;
using BlogoBlog.Logic.Providers;
using BlogoBlog.Logic.Services;
using System.Linq;
using System.Web.Mvc;

namespace BlogoBlog.App.Controllers
{
    public class BlogController : BaseController
    {
        public ActionResult Index(int id)
        {
            var provider = new BlogProvider();
            var blog = provider.GetBlog(id);
            var posts = Db.Context.Post.Where(x => x.BlogId == id)
                .Select(x=>new PostViewModel()
                {
                    ID = x.Id,
                    BlogID = x.BlogId,
                    Content = x.Data,
                    Title = x.Title,
                })
                .ToList();
            var model = new BlogViewModel()
            {
                ID = id,
                Name = blog.BlogName,
                Posts = posts,
                IsOwner = blog.UserID == GetLoggedUser()?.Id,
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
            Database.Db.Save();
            return RedirectToAction("Index", "Home");
        }
    }
}
using BlogoBlog.App.Models.Post;
using BlogoBlog.Database;
using BlogoBlog.Logic.Services;
using System.Linq;
using System.Web.Mvc;

namespace BlogoBlog.App.Controllers
{
    public class PostController : BaseController
    {
        public ActionResult Index(int id)
        {
            var post = Db.Context.Post.SingleOrDefault(x => x.Id == id);
            var model = new PostViewModel()
            {
                ID = post.Id,
                BlogID = post.BlogId,
                Content = post.Data,
                Title = post.Title
            };
            return View(model);
        }

        [HttpGet]
        public ActionResult Create(int blogID)
        {
            var model = new PostViewModel()
            {
                BlogID = blogID
            };
            return View(model);
        }
        [HttpPost]
        public ActionResult Create(PostViewModel model)
        {
            var service = new PostService();
            var result = service.Create(model.Title, model.Content, model.BlogID);
            if (result == Logic.Enums.EPostCreationResult.NameAlreadyTaken)
            {
                CreateErrorMessage(l10n.Translation.NameNotUnique);
                return View(model);
            }
            Db.Save();
            return RedirectToAction("Index", "Blog", new { id = model.BlogID });
        }
    }
}
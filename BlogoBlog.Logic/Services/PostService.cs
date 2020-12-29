using BlogoBlog.Database;
using BlogoBlog.Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogoBlog.Logic.Services
{
    public class PostService
    {
        public EPostCreationResult Create(string title, string content, int blogID)
        {
            if (Db.Context.Post.Any(x => x.BlogId == blogID && title == x.Title))
                return EPostCreationResult.NameAlreadyTaken;
            var post = new Post()
            {
                Title = title,
                Data = content,
                BlogId = blogID,
                Inserted = DateTime.Now,
            };
            Db.Context.Post.Add(post);
            return EPostCreationResult.OK;
        }
    }
}

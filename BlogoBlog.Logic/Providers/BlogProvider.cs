using BlogoBlog.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogoBlog.Logic.Providers
{
    public class BlogProvider
    {
        public IEnumerable<Blog> GetBlogs()
        {
            return Database.Database.Context.Blog.ToList();
        }
        public Blog GetBlog(int id)
        {
            return Database.Database.Context.Blog.SingleOrDefault(x => x.Id == id);
        }
    }
}

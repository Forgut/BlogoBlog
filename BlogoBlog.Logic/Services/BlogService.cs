using BlogoBlog.Database;
using BlogoBlog.Logic.Enums;
using BlogoBlog.Logic.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogoBlog.Logic.Services
{
    public class BlogService
    {
        public EBlogCreationResponse Create(string name)
        {
            if (Database.Database.Context.Blog.SingleOrDefault(x => x.BlogName == name) != null)
                return EBlogCreationResponse.NameNotUnique;
            var blog = new Blog()
            {
                BlogName = name,
                BackgroundImage = "xd",
                UserID = 1 //todo - logged user
            };
            try
            {
                Database.Database.Context.Blog.Add(blog);
                return EBlogCreationResponse.OK;
            }
            catch (Exception)
            {
                return EBlogCreationResponse.UnknownError;
            }
        }
    }
}

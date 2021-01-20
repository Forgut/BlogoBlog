using BlogoBlog.App.Models.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogoBlog.App.Models.Home
{
    public class HomeViewModel
    {
        public List<BlogViewModel> Blogs { get; set; }
        public bool CanCreateBlogs { get; set; }
    }
}
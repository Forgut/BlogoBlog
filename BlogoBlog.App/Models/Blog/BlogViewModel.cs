using BlogoBlog.App.Models.Post;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogoBlog.App.Models.Blog
{
    public class BlogViewModel
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Color { get; set; }
        public IEnumerable<PostViewModel> Posts { get; set; }
        public bool IsOwner { get; set; }
        public string Author { get; set; }
    }
}
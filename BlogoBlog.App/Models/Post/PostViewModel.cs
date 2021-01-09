using BlogoBlog.App.Models.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogoBlog.App.Models.Post
{
    public class PostViewModel
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogID { get; set; }
        public IEnumerable<CommentViewModel> Comments { get; set; }
    }
}
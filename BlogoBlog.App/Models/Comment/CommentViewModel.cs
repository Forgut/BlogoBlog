using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogoBlog.App.Models.Comment
{
    public class CommentViewModel
    {
        public int ID { get; set; }
        public int PostID { get; set; }
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Content { get; set; }
        public DateTime Inserted { get; set; }
    }
}
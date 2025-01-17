﻿using BlogoBlog.Database;
using BlogoBlog.Logic.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogoBlog.Logic.Services
{
    public class CommentService
    {
        public ECreationResult Create(int postID, string content, int userID)
        {
            var comment = new Comments()
            {
                Inserted = DateTime.Now,
                PostID = postID,
                Title = content,
                UserID = userID
            };
            Db.Context.Comments.Add(comment);
            return ECreationResult.OK;
        }
    }
}

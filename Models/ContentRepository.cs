﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Csharlink.Models
{
    public class ContentRepository
    {
        public static List<Post> ShowPosts(int id)
        {
            return UserRepository.db.Posts.Where(x => x.CreatorID == id).ToList();
        }
        public static bool AddPost(Post post, int id, string name)
        {
            post.CreatorName = name;
            post.Views = 0;
            post.CreatorID = id;
            post.CreationDate = DateTime.Now;
            UserRepository.db.Posts.Add(post);
            UserRepository.db.SaveChanges();
            return true;
        }
    }
}
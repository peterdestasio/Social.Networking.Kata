using System;
using System.Collections.Generic;
using System.Linq;

namespace Social.Networking.Kata.DAL.Model
{
    public class PostsService
    {
        private readonly List<PostService> _posts = new List<PostService>();

        public void Add(UserService user, string text, DateTimeOffset when)
            => _posts.Add(new PostService(user, text, when));

        public List<string> ToList()
            => _posts.Select(x => x.PrettyPrint).ToList();
    }
}
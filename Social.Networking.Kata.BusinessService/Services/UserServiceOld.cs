using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Networking.Kata.DAL.Model
{
    public class UserService
    {
        private readonly PostsService _posts = new PostsService();
        public string DisplayName { get; }
        public UserService(string displayName)
        {
            DisplayName = displayName;
        }

        

        public bool Is(string nameToMatch) => DisplayName == nameToMatch;

        public void PostToTimeline(string text, DateTimeOffset when)
        {
            _posts.Add(this, text, when);
        }

        public List<string> FormattedPosts()
        {
            return _posts.ToList();
        }
    }
}


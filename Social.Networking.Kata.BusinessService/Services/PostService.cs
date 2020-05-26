using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Networking.Kata.DAL.Model
{
    public class PostService
    {
        private readonly UserService _user;
        private readonly string _text;
        private readonly DateTimeOffset _when;

        public PostService(UserService user, string text, DateTimeOffset when)
        {
            _user = user;
            _text = text;
            _when = when;
        }

        public string PrettyPrint
            => $"{_user.DisplayName} - {_text} ";
    }
}


using Social.Networking.Kata.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Networking.Kata.BusinessService.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> getFollowById(string userId);
        void follow(string userId, string followedId);
    }
}

using Social.Networking.Kata.DAL.Model;
using System.Collections.Generic;

namespace Social.Networking.Kata.DAL.Interfaces
{
    public interface IFollowRepository
    {
        void follow(string followMessage);
        List<Follow> getFollowedList(string userId);
    }
}

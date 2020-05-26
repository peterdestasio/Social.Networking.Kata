using Social.Networking.Kata.DAL.Interfaces;
using System;

namespace Social.Networking.Kata.DAL.Repositories
{
    public class FollowRepository : IFollowRepository
    {
        private readonly IDBHandler _idbHandler;
        public FollowRepository(IDBHandler idbHandler)
        {
            _idbHandler = idbHandler;
        }
        public void follow(string userId, string followedId)
        {
            _idbHandler.Write(userId, followedId);
        }
    }
}

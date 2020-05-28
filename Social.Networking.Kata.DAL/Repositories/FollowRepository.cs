using Newtonsoft.Json;
using Social.Networking.Kata.DAL.Interfaces;
using Social.Networking.Kata.DAL.Model;
using System.Collections.Generic;

namespace Social.Networking.Kata.DAL.Repositories
{
    public class FollowRepository : IFollowRepository
    {
        private readonly IDBHandler _idbHandler;
        public FollowRepository(IDBHandler idbHandler)
        {
            _idbHandler = idbHandler;
        }
        public void follow(string followMessage)
        {
            _idbHandler.Write(followMessage);
        }

        public List<Follow> getFollowedList(string userId)
        {
            var lines = _idbHandler.ReadAllData();
            var followList = new List<Follow>();
            foreach (var line in lines)
            {
                var message = JsonConvert.DeserializeObject<Follow>(line);

                if (message.FollowerId.Equals(userId))
                {
                    followList.Add(message);
                }
            }
            return followList;
        }
    }
}

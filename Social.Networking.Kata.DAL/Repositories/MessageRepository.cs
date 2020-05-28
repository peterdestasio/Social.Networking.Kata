using Newtonsoft.Json;
using Social.Networking.Kata.DAL.Interfaces;
using Social.Networking.Kata.DAL.Model;
using System.Collections.Generic;

namespace Social.Networking.Kata.DAL.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly IDBHandler _idbHandler;
        public MessageRepository(IDBHandler idbHandler)
        {
            _idbHandler = idbHandler;
        }

        public List<WallMessage> getWall(string userId)
        {
            var lines = _idbHandler.ReadAllData();
            var wallMessages = new List<WallMessage>();
            foreach (var line in lines)
            {
                var message = JsonConvert.DeserializeObject<WallMessage>(line);

                if (message.UserId.Equals(userId))
                {
                    wallMessages.Add(message);
                }
            }
            return wallMessages;
        }

        public List<WallMessage> getPrivateWall(string userId)
        {
            var lines = _idbHandler.ReadAllData();
            var privateMessages = new List<WallMessage>();
            foreach (var line in lines)
            {
                var message = JsonConvert.DeserializeObject<WallMessage>(line);

                if (message.UserId.Equals(userId))
                {
                    privateMessages.Add(message);
                }
            }
            return privateMessages;
        }

        public void postMessage(string message)
        {
            _idbHandler.Write(message);
        }

    }
}

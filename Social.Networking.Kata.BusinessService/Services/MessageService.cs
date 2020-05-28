using Newtonsoft.Json;
using Social.Networking.Kata.BusinessService.Interfaces;
using Social.Networking.Kata.DAL.Interfaces;
using Social.Networking.Kata.DAL.Model;
using System;
using System.Text;

namespace Social.Networking.Kata.BusinessService.Services
{
    public class MessageService : IMessageService
    {

        private readonly IMessageRepository _messageRepository;
        private readonly ITimeFormatter _timeFormatter;
        private readonly IFollowRepository _followRepository;
        public MessageService(IMessageRepository messageRepository, ITimeFormatter timeFormatter, IFollowRepository followRepository)
        {
            _messageRepository = messageRepository;
            _timeFormatter = timeFormatter;
            _followRepository = followRepository;
        }
        public string viewPrivateWall(string userId, bool showId)
        {
            var messageLines = _messageRepository.getPrivateWall(userId);
            var sb = new StringBuilder();
            foreach (var message in messageLines)
            {
                var line = message.Message + " (" + _timeFormatter.elapsedMinutes(message.Time) + " minutes ago)";
                if (showId)
                {
                    line = message.UserId + " - " + line;
                }                
                sb.AppendLine(line);
            }
            return sb.ToString();
        }

        public string viewWall(string userId)
        {
            var followList = _followRepository.getFollowedList(userId);
            followList.Add(new Follow { FollowerId = userId, FollowedId = userId });
            var sb = new StringBuilder();
            foreach (var follow in followList)
            {
                sb.Append(viewPrivateWall(follow.FollowedId, true));

            }
            return sb.ToString();
        }

        public void postMessage(string userId, string message)
        {
            _messageRepository.postMessage(JsonConvert.SerializeObject(new WallMessage { UserId = userId, Message = message, Time = DateTime.Now }));
        }
    }
}

using Newtonsoft.Json;
using Social.Networking.Kata.BusinessService.Interfaces;
using Social.Networking.Kata.DAL.Interfaces;
using Social.Networking.Kata.DAL.Model;

namespace Social.Networking.Kata.BusinessService.Services
{
    public class UserService : IUserService
    {
        IFollowRepository _followRepository;
        public UserService(IFollowRepository followRepository)
        {
            _followRepository = followRepository;
        }
        public void follow(string userId, string followedId)
        {
            _followRepository.follow(JsonConvert.SerializeObject(new Follow { FollowerId = userId, FollowedId = followedId }));
        }
    }
}

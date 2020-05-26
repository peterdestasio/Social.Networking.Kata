using Social.Networking.Kata.BusinessService.Interfaces;
using Social.Networking.Kata.DAL.Interfaces;
using Social.Networking.Kata.DAL.Model;
using Social.Networking.Kata.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Networking.Kata.BusinessService.Services
{
    public class UserService : IUserService
    {
        IFollowRepository _followRepository;
        //public FollowService(IFollowRepository followRepository)
        public UserService(IFollowRepository followRepository)
        {
            _followRepository = followRepository;
        }
        public void follow(string userId, string followedId)
        {
            _followRepository.follow(userId, followedId);
        }

        public void postMessage(string userId, string followedId)
        {
            //_followRepository.follow(userId, followedId);
        }

        public IEnumerable<User> getFollowById(string userId)
        {
            throw new NotImplementedException();
        }
    }
}

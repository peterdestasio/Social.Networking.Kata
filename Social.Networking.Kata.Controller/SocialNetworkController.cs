using Social.Networking.Kata.BusinessService.Interfaces;

namespace Social.Networking.Kata.Controller
{
    public class SocialNetworkController : ISocialNetworkController
    {
        private readonly IUserService _userService;
        public SocialNetworkController(IUserService userService)
        {
            _userService = userService;
        }

        public void executeRequest(string inputLine)
        {
            var commands = inputLine.Split(' ');
            switch (commands[1])
            {
                case "->":
                    // do something
                    //_userService.postMessage(commands[0], commands[2]);
                    break;
                case null:
                    break;
                case "follows":
                    _userService.follow(commands[0], commands[2]);
                    break;
                case "wall":
                    break;
            }
        }
    }
}

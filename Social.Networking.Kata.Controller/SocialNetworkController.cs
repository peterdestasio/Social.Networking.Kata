using Social.Networking.Kata.BusinessService.Interfaces;
using Social.Networking.Kata.BusinessService.Services;
using System;

namespace Social.Networking.Kata.Controller
{
    public class SocialNetworkController : ISocialNetworkController
    {
        private const string POST = "->";
        private const string FOLLOW = "follows";
        private const string WALL = "wall";

        private readonly ICommandParser _commandParser;
        private readonly IUserService _userService;
        private readonly IMessageService _messageService;
        
        public SocialNetworkController(ICommandParser commandParser, IUserService userService, IMessageService messageService)
        {            
            _commandParser = commandParser;
            _userService = userService;
            _messageService = messageService;
        }

        public void executeRequest(string inputLine)
        {
            var commands = _commandParser.parse(inputLine);
            if (inputLine.Contains(" "))
            {                
                switch (commands[1])
                {
                    case POST:
                        _messageService.postMessage(commands[0], commands[2]);
                        break;
                    case FOLLOW:
                        _userService.follow(commands[0], commands[2]);
                        break;
                    case WALL:
                        Console.WriteLine(_messageService.viewWall(commands[0]));
                        break;
                }
            }
            else
            {
                Console.WriteLine(_messageService.viewPrivateWall(commands[0], false));
            }
        }
    }
}

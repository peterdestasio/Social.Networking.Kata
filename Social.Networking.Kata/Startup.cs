using Social.Networking.Kata.Controller;
using System;

namespace Social.Networking.Kata
{
    public class Startup : IStartup
    {
        private ISocialNetworkController _socialNetworkController;

        public Startup(ISocialNetworkController socialNetworkController)
        {
            _socialNetworkController = socialNetworkController;
        }

        public void Run()
        {        
            Console.WriteLine("Welcome to Social Network Kata!");
            Console.WriteLine("Commands Allowed: <User> -> Message, <User>, <User> follows <User>, <User> wall");
            Console.WriteLine("Type exit to Terminate");
            while (true)
            {                
                var request = Console.ReadLine();
                if (request.Equals("exit"))
                {
                    break;
                }
                _socialNetworkController.executeRequest(request);
            }
        }
    }
}

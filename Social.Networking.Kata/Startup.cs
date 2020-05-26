using Social.Networking.Kata.BusinessService.Interfaces;
using Social.Networking.Kata.BusinessService.Services;
using Social.Networking.Kata.Controller;
using System;

namespace Social.Networking.Kata
{
    public class Startup : IStartup
    {

        private const string POST = "->";
        private const string READ = "";
        private const string FOLLOW = "follows";
        private const string WALL = "wall";


        private ISocialNetworkController _socialNetworkController;

        public Startup(ISocialNetworkController socialNetworkController)
        {
            _socialNetworkController = socialNetworkController;
        }

        public void Run()
        {
            try
            {
                _socialNetworkController.executeRequest(Console.ReadLine());
            }
            catch(Exception e)
            {
                var a = e;
            }             

        }
    }
}

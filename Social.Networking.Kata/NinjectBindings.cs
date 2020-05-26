using Social.Networking.Kata.BusinessService.Interfaces;
using Social.Networking.Kata.BusinessService.Services;
using Social.Networking.Kata.Controller;
using Social.Networking.Kata.DAL.Interfaces;
using Social.Networking.Kata.DAL.Logic;
using Social.Networking.Kata.DAL.Repositories;

namespace Social.Networking.Kata
{
    public class NinjectBindings : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<IStartup>().To<Startup>();
            Bind<ISocialNetworkController>().To<SocialNetworkController>();
            Bind<IUserService>().To<UserService>();
            Bind<IDBHandler>().To<DBHandler>().WithConstructorArgument("fileName", @"C:\Users\Streg\source\repos\Social.Networking.Kata\Social.Networking.Kata\Data\Follow.txt"); //.WithConstructorArgument("timeout", 10000); ("blah","blah");
            Bind<IFollowRepository>().To<FollowRepository>();


        }
    }
}

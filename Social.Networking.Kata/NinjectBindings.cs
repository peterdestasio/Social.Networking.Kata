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
            Bind<ICommandParser>().To<CommandParser>();
            Bind<IDBHandler>().To<FollowFileDBHandler>().WhenInjectedInto(typeof(FollowRepository)).WithConstructorArgument("filePath", @"..\..\Data\Follow.txt");
            Bind<IDBHandler>().To<MessageFileDBHandler>().WhenInjectedInto(typeof(MessageRepository)).WithConstructorArgument("filePath", @"..\..\Data\Messages.txt");
            Bind<IFollowRepository>().To<FollowRepository>();
            Bind<IMessageRepository>().To<MessageRepository>();
            Bind<ITimeFormatter>().To<TimeFormatter>();
            Bind<IMessageService>().To<MessageService>();
        }
    }
}

namespace Social.Networking.Kata.BusinessService.Interfaces
{
    public interface IUserService
    {
        void follow(string userId, string followedId);
    }
}

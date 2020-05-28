namespace Social.Networking.Kata.BusinessService.Services
{
    public interface IMessageService
    {
        string viewPrivateWall(string userId, bool showId);
        string viewWall(string userId);
        void postMessage(string userId, string message);
    }
}

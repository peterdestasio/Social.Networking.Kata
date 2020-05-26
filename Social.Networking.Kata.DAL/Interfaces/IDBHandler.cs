namespace Social.Networking.Kata.DAL.Interfaces
{
    public interface IDBHandler
    {
        void Write(string followerId, string followedId);
    }
}

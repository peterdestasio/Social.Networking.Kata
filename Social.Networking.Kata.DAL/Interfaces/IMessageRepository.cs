using Social.Networking.Kata.DAL.Model;
using System.Collections.Generic;

namespace Social.Networking.Kata.DAL.Interfaces
{
    public interface IMessageRepository
    {
        void postMessage(string message);
        List<WallMessage> getPrivateWall(string userId);
        List<WallMessage> getWall(string userId);
    }
}

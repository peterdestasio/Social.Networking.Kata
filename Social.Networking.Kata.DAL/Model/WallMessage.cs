using System;

namespace Social.Networking.Kata.DAL.Model
{
    public class WallMessage
    {
        public string UserId { get; set; }
        public string Message { get; set; }
        public DateTime Time { get; set; }
    }
}

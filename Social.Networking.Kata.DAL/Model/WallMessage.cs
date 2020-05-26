using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social.Networking.Kata.DAL.Model
{
    public class WallMessage
    {
        public int MessageId { get; set; }

        public string Message { get; set; }

        public int FollowerId { get; set; }
    }
}

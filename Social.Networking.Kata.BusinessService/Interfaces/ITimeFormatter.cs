using System;

namespace Social.Networking.Kata.BusinessService.Interfaces
{
    public interface ITimeFormatter
    {
        string elapsedMinutes(DateTime date);
    }
}

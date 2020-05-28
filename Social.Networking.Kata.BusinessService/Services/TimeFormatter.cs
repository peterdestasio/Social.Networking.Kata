using Social.Networking.Kata.BusinessService.Interfaces;
using System;

namespace Social.Networking.Kata.BusinessService.Services
{
    public class TimeFormatter : ITimeFormatter
    {
        public string elapsedMinutes(DateTime date)
        {
            var doubleMinutes = DateTime.Now.Subtract(date).TotalMinutes;
            return Math.Round(doubleMinutes).ToString();
        }
    }
}

using Social.Networking.Kata.BusinessService.Interfaces;
using System.Text;

namespace Social.Networking.Kata.BusinessService.Services
{
    public class CommandParser : ICommandParser
    {        
        /// /// <remarks>
        /// Assuming that there is always 1 command
        /// </remarks>
        /// /// <returns>
        /// an array of commands
        /// </returns>
        public string[] parse(string input)
        {
            var commands = input.Split(' ');
            if (commands.Length > 2)
            {
                var sb = new StringBuilder();
                sb.Append(commands[2]);
                for (int i = 3; i < commands.Length; i++)
                {
                   sb.Append(" " + commands[i]);                      
                    
                }
                commands[2] = sb.ToString();
            }
            return commands;
        }
    }
}

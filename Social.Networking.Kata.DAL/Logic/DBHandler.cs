using Social.Networking.Kata.DAL.Interfaces;
using System.IO;

namespace Social.Networking.Kata.DAL.Logic
{
    public class DBHandler: IDBHandler
    {
        protected readonly string _filePath;
        public DBHandler(string filePath)
        {
            _filePath = filePath;
        }
        public void Write(string message)
        {
            using (StreamWriter file = new StreamWriter(_filePath, true))
            {
                file.WriteLine(message);
            }
        }

        public string[] ReadAllData()
        {
            return File.ReadAllLines(_filePath);
        }

    }
}

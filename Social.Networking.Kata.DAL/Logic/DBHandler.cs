using Social.Networking.Kata.DAL.Interfaces;
using System;

namespace Social.Networking.Kata.DAL.Logic
{
    public class DBHandler: IDBHandler
    {

        //public string[] GetRows(string fileName)
        //{
        //    string rawString = File.ReadAllText(fileName);
        //    rawString = rawString.Replace('\n', '\r');
        //    string[] rows = rawString.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);
        //    return rows;
        //}
        private readonly string _fileName;
        public DBHandler(string fileName)
        {
            _fileName = fileName;
        }
        public void Write(string followerId, string followedId)
        {
            using (System.IO.StreamWriter file =
           new System.IO.StreamWriter(_fileName, true))
            {
                file.WriteLine(followerId + "," + followedId);
            }
        }
    }
}

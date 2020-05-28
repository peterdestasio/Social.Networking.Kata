namespace Social.Networking.Kata.DAL.Interfaces
{
    public interface IDBHandler
    {
        void Write(string message);
        string[] ReadAllData();
    }
}

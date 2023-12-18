using TaurusMessenger.Shared.Model;

namespace TaurusMessengerServer.Service
{
    public class DatabaseService 
    {
        private readonly MySqlContext database;
        public DatabaseService(MySqlContext msc)
        {
            database = msc;
        }

        public User GetUser(string login = "")
        {
            return database.Users.ToList().FirstOrDefault((user) => user.Login == login)!;
        }

        public List<User> GetUsers()
        {
            return database.Users.ToList();
        }

        //TODO: more methods to work with schemas
    }
}

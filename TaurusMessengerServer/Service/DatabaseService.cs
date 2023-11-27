using TaurusMessenger.Shared.Model;

namespace TaurusMessengerServer.Service
{
    public class DatabaseService
    {
        public DatabaseService()
        {
            var temp = GetUser();
            Console.WriteLine(temp.Login);
        }

        public User GetUser()
        {
            using (MySqlContext db = new MySqlContext())
            {
                var users = db.Users.ToList();
                return users[0];
            }
        }
    }
}

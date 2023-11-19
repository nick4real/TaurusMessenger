using SQLite;

namespace TaurusMessenger.Shared.Model
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime LastSeen { get; set; }

        public User(string login = "userLogin", string password = "userPassword", 
            string name = "userName", string image = "userImage", DateTime lastSeen = default)
        {
            Name = name;
            Image = image;
            Login = login;
            Password = password;
            LastSeen = lastSeen;
        }
    }
}

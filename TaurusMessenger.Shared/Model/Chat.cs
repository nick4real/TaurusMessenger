using SQLite;

namespace TaurusMessenger.Shared.Model
{
    public class Chat
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Type { get; set; }
    }
}

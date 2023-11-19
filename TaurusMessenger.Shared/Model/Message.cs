using SQLite;

namespace TaurusMessenger.Shared.Model
{
    public class Message
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int ChatId { get; set; }
        public int UserId { get; set; }
        public string Content { get; set; }
        public DateTime TimeStamp { get; set; }
    }
}

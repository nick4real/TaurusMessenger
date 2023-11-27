namespace TaurusMessenger.Shared.Model
{
    public class User
    {
        public int Id { get; set; }
        public string NickName { get; set; }
        public byte[]? Image { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public DateTime Last_Seen { get; set; }
    }
}

using System.Text.Json.Serialization;

namespace TaurusMessenger.Shared.Model
{
    public class User
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("nickName")]
        public string NickName { get; set; } = null!;
        [JsonPropertyName("image")]
        public byte[]? Image { get; set; }
        [JsonPropertyName("login")]
        public string Login { get; set; } = null!;
        [JsonPropertyName("password")]
        public string Password { get; set; } = null!;
        [JsonPropertyName("last_Seen")]
        public DateTime Last_Seen { get; set; }
    }
}

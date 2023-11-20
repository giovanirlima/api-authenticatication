using System.Text.Json.Serialization;

namespace ApiAuth.Models.v1
{
    public class User
    {
        [JsonIgnore]
        public int Id { get; set; }

        public string? Username { get; set; }
        public string? Password { get; set; }

        [JsonIgnore]
        public string? Role { get; set; }
    }
}
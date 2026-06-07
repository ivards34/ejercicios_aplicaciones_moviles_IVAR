using System.Text.Json.Serialization;

namespace Practico9_API.Models
{
    public class Usuario
    {
        [JsonPropertyName("first_name")]
        public string Nombre { get; set; }

        [JsonPropertyName("last_name")]
        public string Apellido { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("avatar")]
        public string Avatar { get; set; }
    }
}

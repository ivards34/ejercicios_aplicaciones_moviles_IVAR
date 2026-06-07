using System.Text.Json.Serialization;

namespace Practico9_API.Models
{
    public class RespuestaUsuarios
    {
        [JsonPropertyName("data")]
        public List<Usuario>? Data { get; set; }
    }
}

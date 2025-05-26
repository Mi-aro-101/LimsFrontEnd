using System.Text.Json.Serialization;

namespace LimsFrontEnd.Models
{
    public class DestinataireDto
    {
        [JsonPropertyName("idDestinataire")]
        public int idDestinataire { get; set; }

        [JsonPropertyName("designation")]
        public string? designation { get; set; }
    }
}
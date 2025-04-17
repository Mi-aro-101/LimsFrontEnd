using System.Text.Json.Serialization;

namespace LimsFrontEnd.Models
{
    public class DepartDto
    {
        [JsonPropertyName("idDepart")]
        public int idDepart { get; set; }

        [JsonPropertyName("reference")]
        public int? reference { get; set; }

        [JsonPropertyName("objet")]
        public string? objet { get; set; }

        [JsonPropertyName("DateDepart")]
        public DateTime? DateDepart { get; set; }

        [JsonPropertyName("designationDestinataire")]
        public string? designationDestinataire { get; set; }

        [JsonPropertyName("idDestinataire")]
        public int idDestinataire { get; set; }
    }
}

using System.Text.Json.Serialization;
namespace LimsFrontEnd.Models.Immobilisation
{
    public class ImmobilisationDto
    {
        [JsonPropertyName("idImmobilisation")]
        public int IdImmobilisation { get; set; }

        [JsonPropertyName("reference")]
        public  string? Reference { get; set; }

        [JsonPropertyName("designation")]
        public  string? Designation { get; set; }

        [JsonPropertyName("idMarque")]
        public int IdMarque { get; set; }

        [JsonPropertyName("marque")]
        public MarqueDto? Marque { get; set; }
    }
}

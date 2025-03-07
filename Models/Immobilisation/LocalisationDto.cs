using System.Text.Json.Serialization;

namespace LimsFrontEnd.Models.Immobilisation
{
    public class LocalisationDto
    {
        [JsonPropertyName("idLocalisation")]
        public int IdLocalisation { get; set; }

        [JsonPropertyName("designation")]
        public string? Designation { get; set; }
    }
}

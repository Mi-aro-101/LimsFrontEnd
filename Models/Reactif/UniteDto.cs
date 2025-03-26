using System.Text.Json.Serialization;
namespace LimsFrontEnd.Models.Reactif
{
    public class UniteDto
    {
        [JsonPropertyName("idUnite")]
        public int IdUnite { get; set; }

        [JsonPropertyName("designation")]
        public string? Designation { get; set; }
    }
}

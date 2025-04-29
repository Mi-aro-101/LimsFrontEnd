using System.Text.Json.Serialization;

namespace LimsFrontEnd.Models.Reactif
{
    public class ObjetSortieReactifDto
    {
        [JsonPropertyName("idObjetSortieReactif")]
        public int IdObjetSortieReactif { get; set; }

        [JsonPropertyName("designation")]
        public string? Designation { get; set; }
    }
}

using System.Text.Json.Serialization;

namespace LimsFrontEnd.Models.Immobilisation
{
      public class ObjetIndisponibiliteDto
    {
        [JsonPropertyName("idObjetIndisponibilite")]
        public int IdObjetIndisponibilite { get; set; }

        [JsonPropertyName("designation")]
        public  string? Designation { get; set; }
    }
}

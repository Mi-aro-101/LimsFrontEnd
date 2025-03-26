using System.Text.Json.Serialization;
namespace LimsFrontEnd.Models.Reactif
{
    public class ReactifDto
    {
        [JsonPropertyName("idReactif")]
        public int IdReactif { get; set; }

        [JsonPropertyName("designation")]
        public  string?Designation { get; set; }

        [JsonPropertyName("idTypeSortie")]
        public int IdTypeSortie { get; set; }

        [JsonPropertyName("typeSortie")]
        public TypeSortieDto? TypeSortie { get; set; }

        [JsonPropertyName("idUnite")]
        public int IdUnite { get; set; }

        [JsonPropertyName("unite")]
        public UniteDto? Unite { get; set; }
    }
}

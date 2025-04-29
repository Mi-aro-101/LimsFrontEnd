using System.Text.Json.Serialization;

namespace LimsFrontEnd.Models.Outillage
{
    public class FournisseurDto
    {
        [JsonPropertyName("idFournisseur")]
        public int IdFournisseur { get; set; }

        [JsonPropertyName("designation")]
        public  string? Designation { get; set; }
    }
}

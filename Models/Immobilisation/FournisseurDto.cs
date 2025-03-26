using System.Text.Json.Serialization;

namespace LimsFrontEnd.Models.Immobilisation
{
    public class FournisseurDto
    {
        [JsonPropertyName("idFournisseur")]
        public int IdFournisseur { get; set; }

        [JsonPropertyName("designation")]
        public  string? Designation { get; set; }
    }
}

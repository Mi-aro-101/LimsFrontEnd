using System.Text.Json.Serialization;

namespace LimsFrontEnd.Models.Reactif
{
    public class FournisseurEntreeReactifDto
    {

        [JsonPropertyName("idFournisseur")]
        public int IdFournisseur { get; set; }

        [JsonPropertyName("designation")]
        public required string Designation { get; set; }
    }
}

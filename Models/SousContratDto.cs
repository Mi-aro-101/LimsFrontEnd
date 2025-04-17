using System.Text.Json.Serialization;

namespace LimsFrontEnd.Models
{
    public class SousContratDto
    {
        [JsonPropertyName("paiement")]
        public PaiementDto? Paiement { get; set; }
        [JsonPropertyName("contrat")]
        public ContratDto? Contrat { get; set; }
    }
}
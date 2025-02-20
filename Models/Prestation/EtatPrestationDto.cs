using System.Text.Json.Serialization;

namespace LimsFrontEnd.Models;

public class EtatPrestationDto
{
    [JsonPropertyName("idEtatPrestation")]
    public int IdEtatPrestation { get; set; }
    [JsonPropertyName("niveau")]
    public int Niveau { get; set; }
    [JsonPropertyName("designation")]
    public string Designation { get; set; }
}
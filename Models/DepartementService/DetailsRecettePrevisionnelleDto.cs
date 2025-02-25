using System.Text.Json.Serialization;

namespace LimsFrontEnd.Models;

public class DetailsRecettePrevisionnelleDto
{
    [JsonPropertyName("idDepartement")]
    public int IdDepartement { get; set; }
    [JsonPropertyName("departement")]
    public DepartementDto? Departement { get; set; }
    [JsonPropertyName("idRecettePrevisionnelle")]
    public int IdRecettePrevisionnelle { get; set; }
    [JsonPropertyName("recettePrevisionnelle")]
    public RecettePrevisionnelleDto? RecettePrevisionnelle { get; set; }

    [JsonPropertyName("montant")]
    public decimal Montant { get; set; }
}
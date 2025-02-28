using System.Text.Json.Serialization;

namespace LimsFrontEnd.Models;

public class RecettePrevisionnelleDto
{
    [JsonPropertyName("idRecettePrevisionnelle")]
    public int IdRecettePrevisionnelle { get; set; }
    [JsonPropertyName("dateRecettePrevisionnelle")]
    public DateOnly DateRecettePrevisionnelle { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    [JsonPropertyName("idExercice")]
    public int IdExercice { get; set; } = 0;
    [JsonPropertyName("exercice")]
    public ExerciceDto Exercice { get; set; } = new ExerciceDto();
    [JsonPropertyName("montantTotal")]
    public decimal MontantTotal { get; set; }
    [JsonPropertyName("detailsRecettePrevisionnelles")]
    public ICollection<DetailsRecettePrevisionnelleDto> DetailsRecettePrevisionnelles { get; set;} = new List<DetailsRecettePrevisionnelleDto>();
}
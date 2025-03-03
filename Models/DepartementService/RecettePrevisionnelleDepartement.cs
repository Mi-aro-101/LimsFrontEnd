using System.Text.Json.Serialization;

namespace LimsFrontEnd.Models;

public class RecettePrevisionnelleDepartement
{

    public decimal SommeDetailsRecette()
    {
        decimal somme = 0;
        foreach(var item in this.RecettePrevisionnelleDepartements)
        {
            somme += item.Value;
        }
        return somme;
    }

    [JsonPropertyName("idRecettePrevisionnelle")]
    public int IdRecettePrevisionnelle { get; set; }
    [JsonPropertyName("dateRecettePrevisionnelle")]
    public DateOnly DateRecettePrevisionnelle { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    [JsonPropertyName("idExercice")]
    public int IdExercice { get; set; }
    [JsonPropertyName("exercice")]
    public ExerciceDto Exercice { get; set; } = new ExerciceDto();
    [JsonPropertyName("montantTotal")]
    public decimal MontantTotal { get; set; }
    [JsonPropertyName("recettePrevisionnelleDepartements")]
    public Dictionary<int, decimal> RecettePrevisionnelleDepartements { get; set; } = new Dictionary<int, decimal>();
}
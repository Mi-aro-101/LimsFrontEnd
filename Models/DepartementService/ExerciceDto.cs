using System.Text.Json.Serialization;
using LimsUtils.Utility;

namespace LimsFrontEnd.Models;

public class ExerciceDto
{
    [JsonPropertyName("idExercice")]
    public int IdExercice { get; set; }
    [JsonPropertyName("dateDebut")]
    // TODO : Debut d'exercice ataovy auto depart premier janvier de cette annee
    public DateOnly DateDebut { get; set; } = new DateOnly(DateUtils.GetCurrentYear(), 1, 1);

    private DateOnly _dateFin = new DateOnly(DateUtils.GetCurrentYear(), 12, 31);
    [JsonPropertyName("dateFin")]
    public DateOnly DateFin { 
        get => _dateFin; 
        set{
            if(value <= DateDebut)
            {
                throw new ArgumentException("Date de fin doit être supérieure à la date de début");
            }
            _dateFin = value;
        }
    }
    private string? _designation;
    public string Designation {
        get => $"{ ViewUtils.RenderDateAsFrenchFormat(DateDebut) } au {ViewUtils.RenderDateAsFrenchFormat(DateFin)}";
        set {
            _designation = value;
        }
    }
}
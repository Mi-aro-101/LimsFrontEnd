using System.Text.Json.Serialization;

namespace LimsFrontEnd.Models;

public class ExerciceDto
{
    [JsonPropertyName("idExercice")]
    public int IdExercice { get; set; }
    [JsonPropertyName("dateDebut")]
    public DateOnly DateDebut { get; set; } = DateOnly.FromDateTime(DateTime.Now);

    public DateOnly _dateFin;
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
}
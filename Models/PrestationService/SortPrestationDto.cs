using System.Text.Json.Serialization;
using LimsUtils.Utility;

namespace LimsFrontEnd.Models;

public class SortPrestationDto
{
    [JsonPropertyName("referenceFicheTravail")]
    public string ReferenceFicheTravail { get; set; } = string.Empty;
    [JsonPropertyName("idEtatPrestation")]
    public int IdEtatPrestation { get; set; } = 0;
    [JsonPropertyName("anneeExercice")]
    public int AnneeExercice { get; set; } = DateUtils.GetCurrentYear();
}
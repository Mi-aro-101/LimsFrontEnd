using System.Text.Json.Serialization;

namespace LimsFrontEnd.Models;
public class CreatePrestationDto
{
    [JsonPropertyName("datePrestation")]
    public DateOnly DatePrestation { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    [JsonPropertyName("idClient")]
    public int IdClient { get; set; }
    [JsonPropertyName("echantillons")]
    public Dictionary<string,EchantillonDto> Echantillons {get; set;} = new Dictionary<string,EchantillonDto>();
    [JsonPropertyName("travaux")]
    public Dictionary<string,List<int>> Travaux { get; set; } = new Dictionary<string,List<int>>();
}
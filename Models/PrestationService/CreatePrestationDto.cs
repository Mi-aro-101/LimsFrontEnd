using System.Text.Json.Serialization;

namespace LimsFrontEnd.Models;
public class CreatePrestationDto
{
    [JsonPropertyName("datePrestation")]
    public DateOnly DatePrestation { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    [JsonPropertyName("idClient")]
    public int IdClient { get; set; }
    public ClientDto? Client {get; set;}
    [JsonPropertyName("echantillons")]
    public Dictionary<string,EchantillonDto> Echantillons {get; set;} = new Dictionary<string,EchantillonDto>();
    [JsonPropertyName("remise")]
    public double? Remise { get; set;} = 0;

}
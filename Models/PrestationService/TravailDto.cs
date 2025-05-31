using System.Text.Json.Serialization;

namespace LimsFrontEnd.Models;

public class TravailDto
{
    [JsonPropertyName("idTypeTravaux")]
    public int IdTypeTravaux { get; set; }
    [JsonPropertyName("designation")]
    public string? Designation { get; set; }
    [JsonPropertyName("avanceeTravail")]
    public AvanceeTravailDto? AvanceeTravail { get; set; }

}
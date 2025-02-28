using System.Text.Json.Serialization;

namespace LimsFrontEnd.Models;

public class AvanceeTravailDto
{
    [JsonPropertyName("idAvanceeTravail")]
    public int IdAvanceeTravail { get; set; }
    [JsonPropertyName("niveau")]
    public int Niveau { get; set; }    
    [JsonPropertyName("designation")]
    public required string Designation { get; set; }
}
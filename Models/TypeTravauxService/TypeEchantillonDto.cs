using System.Text.Json.Serialization;

namespace LimsFrontEnd.Models;

public class TypeEchantillonDto
{
    [JsonPropertyName("idTypeEchantillon")]
    public int IdTypeEchantillon { get; set; }

    [JsonPropertyName("designation")]
    public required string Designation { get; set; }
}
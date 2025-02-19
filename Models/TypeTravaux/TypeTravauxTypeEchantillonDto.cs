using System.Text.Json.Serialization;

namespace LimsFrontEnd.Models;

public class TypeTravauxTypeEchantillonDto
{
    [JsonPropertyName("idTypeTravaux")]
    public int IdTypeTravaux { get; set; }
    [JsonPropertyName("idTypeEchantillon")]
    public int IdTypeEchantillon { get; set; }
    [JsonPropertyName("typeEchantillon")]
    public TypeEchantillonDto TypeEchantillon { get; set; }
} 
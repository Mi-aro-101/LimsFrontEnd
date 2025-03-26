using System.Text.Json.Serialization;

namespace LimsFrontEnd.Models;

public class DepartementDto
{
    [JsonPropertyName("idDepartement")]
    public int IdDepartement { get; set; }
    [JsonPropertyName("code")]
    public required string Code { get; set; }
    [JsonPropertyName("designation")]
    public required string Designation { get; set; }
}
using System.Text.Json.Serialization;
using LimsFrontEnd.Models;

namespace LimsFrontEnd.Models;

public class ChiffreAffaireDepartementDto
{
    [JsonPropertyName("idDepartement")]
    public int? IdDepartement { get; set; }
    [JsonPropertyName("designation")]
    public string? Designation { get; set; }
    [JsonPropertyName("chiffreAffaires")]
    public ICollection<ChiffreAffaireDto> ChiffreAffaires { get; set; } = new List<ChiffreAffaireDto>();
}
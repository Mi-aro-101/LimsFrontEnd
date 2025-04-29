using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace LimsFrontEnd.Models;

public class EchantillonDto
{
    [JsonPropertyName("idEchantillon")]
    public int? IdEchantillon { get; set; }
    [JsonPropertyName("note")]
    public string Note { get; set; } = string.Empty;
    [JsonPropertyName("provenance")]
    public string? Provenance { get; set; } = string.Empty;
    [JsonPropertyName("reference")]
    [Required]
    [StringLength(30, ErrorMessage = "Ne dois pas être moins d'une lettre", MinimumLength = 1)]
    public string Reference { get; set; } = string.Empty;
    [JsonPropertyName("datePrelevement")]
    [Required]
    public DateOnly DatePrelevement { get; set; } = DateOnly.FromDateTime(DateTime.Now);
    [JsonPropertyName("idTypeEchantillon")]
    [Required]
    public int IdTypeEchantillon { get; set; }

    [NotMapped]
    public string? TypeEchantillonDesignation { get; set; }
    [JsonPropertyName("typeEchantillon")]
    public TypeEchantillonDto? TypeEchantillon { get; set; }
    [JsonPropertyName("detailsEchantillons")]
    public ICollection<VDetailsEchantillonDto> DetailsEchantillons { get; set; } = new List<VDetailsEchantillonDto>();
}
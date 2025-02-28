using System.Text.Json.Serialization;

namespace LimsFrontEnd.Models;

public class ClientDto
{

    public string GetInterne()
    {
        string result = "Non";
        if(this.IsInterne == 0) result = "Oui";

        return result;
    }

    public string GetSousContrat()
    {
        string result = "Non";
        if(!string.IsNullOrEmpty(this.RefContrat)) result = this.RefContrat;
        return result;
    }

    [JsonPropertyName("idClient")]
    public int IdClient { get; set; }
    [JsonPropertyName("nom")]
    public required string Nom { get; set; }
    [JsonPropertyName("adresse")]
    public required string Adresse { get; set; }
    [JsonPropertyName("cin")]
    public string? Cin { get; set; }
    [JsonPropertyName("passeport")]
    public string? Passeport { get; set; }
    [JsonPropertyName("contact")]
    public required string Contact { get; set; }
    [JsonPropertyName("email")]
    public required string Email { get; set; }
    [JsonPropertyName("fax")]
    public string? Fax { get; set; }
    [JsonPropertyName("isInterne")]
    public int IsInterne { get; set; }
    [JsonPropertyName("refContrat")]
    public string? RefContrat { get; set; }
    [JsonPropertyName("nifStat")]
    public string? NifStat { get; set; }
}
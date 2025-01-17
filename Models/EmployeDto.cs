using System.Text.Json.Serialization;

namespace LimsFrontEnd.Models;

public class EmployeDto
{

    public string GetGenre()
    {
        string result = "Homme";
        if(this.Genre == 1) result = "Femme";
        return result;
    }

    public string GetDepartementDesignation()
    {
        string result = "";
        if(this.Departement != null)
        {
            result = this.Departement.Designation;
        }
        return result;
    }

    [JsonPropertyName("idEmploye")]
    public int IdEmploye { get; set; }
    [JsonPropertyName("matricule")]
    public string? Matricule { get; set; }
    [JsonPropertyName("nom")]
    public string? Nom { get; set; }
    [JsonPropertyName("prenom")]
    public string? Prenom { get; set; }
    [JsonPropertyName("genre")]
    public int Genre { get; set; }
    [JsonPropertyName("cin")]
    public string? Cin { get; set; }
    [JsonPropertyName("contact")]
    public string? Contact { get; set; }
    [JsonPropertyName("adresse")]
    public string? Adresse { get; set; }
    [JsonPropertyName("manager")]
    public string? Manager { get; set; }
    [JsonPropertyName("idDepartement")]
    public int? IdDepartement { get; set; }
    [JsonPropertyName("departement")]
    public DepartementDto? Departement { get; set; }
    [JsonPropertyName("idPoste")] 
    public int IdPoste { get; set; }
    [JsonPropertyName("poste")]
    public PosteDto? Poste { get; set; }
}
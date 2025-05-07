using System.Collections;
using System.Text.Json.Serialization;

namespace LimsFrontEnd.Models;
public class UtilisateurDto {
    
    [JsonPropertyName("idUser")]
    public int? IdUser { get; set; }
    [JsonPropertyName("identifiant")]
    public string? Identifiant {get;set;}
    [JsonPropertyName("password")]
    public string? Password {get;set;}
    [JsonPropertyName("roles")]
     public List<int>? Roles {get;set;} = new List<int>();
    [JsonPropertyName("idDepartement")]
    public int? IdDepartement {get;set;}
    
}
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
    public IEnumerable<string> RoleDesignations {get;set;} = new HashSet<string>();
    
}
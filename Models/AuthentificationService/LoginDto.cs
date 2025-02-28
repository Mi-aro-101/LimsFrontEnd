using System.Text.Json.Serialization;

namespace LimsFrontEnd.Models;
public class LoginDto {

    [JsonPropertyName("identifiant")]
    public required string Identifiant {get;set;}
    
    [JsonPropertyName("password")]
    public required string Password {get;set;}
}
using System.Text.Json.Serialization;

namespace LimsFrontEnd.Models;

public class TypeTravauxDto
{
    [JsonPropertyName("idTypeTravaux")]
    public int IdTypeTravaux { get; set; }
    [JsonPropertyName("code")]
    public required string Code { get; set; } = "5488";
    [JsonPropertyName("designation")]
    public required string Designation { get; set; } = "Refroidissement";
    [JsonPropertyName("hasResultat")]
    public int HasResultat { get; set; } = 0;
    [JsonPropertyName("idDepartement")]
    public int IdDepartement { get; set; } = 2;
    [JsonPropertyName("departement")]
    public DepartementDto? Departement { get; set; }
    [JsonPropertyName("tarif")]
    public decimal? Tarif { get; set; } = 35000;
    private DateTime _dateCreation = DateTime.Now;
    [JsonPropertyName("dateCreation")]
    public DateTime DateCreation { 
        get => _dateCreation; 
        set{
            if(value > DateTime.Now){
                throw new ArgumentException("Date de création ne peut pas être dans le futur.");
            }
            _dateCreation = value;
        } 
    }
    [JsonPropertyName("dateChangement")]
    public DateTime? DateChangement { get; set; }
    [JsonPropertyName("historiqueTarifs")]
    public List<HistoriqueTarifDto>? HistoriqueTarifs { get; set; } = new List<HistoriqueTarifDto>();
    [JsonPropertyName("haveFormule")]
    public int HaveFormule { get; set; } = 1;
    [JsonPropertyName("formuleString")]
    public string? FormuleString { get; set; }
    [JsonPropertyName("formuleBytes")]
    public byte[]? FormuleBytes { get; set; }
    [JsonPropertyName("idTypeEchantillons")]
    public IEnumerable<int>? IdTypeEchantillons { get; set; } = new HashSet<int>();
    [JsonPropertyName("typeTravauxTypeEchantillons")]
    public ICollection<TypeTravauxTypeEchantillonDto>? TypeTravauxTypeEchantillons { get; set; } = new List<TypeTravauxTypeEchantillonDto>();


}
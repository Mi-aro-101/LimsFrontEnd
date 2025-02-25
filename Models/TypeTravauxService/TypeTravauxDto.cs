using System.Text.Json.Serialization;

namespace LimsFrontEnd.Models;

public class TypeTravauxDto
{
    [JsonPropertyName("idTypeTravaux")]
    public int IdTypeTravaux { get; set; }
    [JsonPropertyName("code")]
    public string Code { get; set; }
    [JsonPropertyName("designation")]
    public string Designation { get; set; }
    [JsonPropertyName("hasResultat")]
    public int HasResultat { get; set; }
    [JsonPropertyName("idDepartement")]
    public int IdDepartement { get; set; }
    [JsonPropertyName("departement")]
    public DepartementDto? Departement { get; set; }
    [JsonPropertyName("tarif")]
    public decimal? Tarif { get; set; }
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
    [JsonPropertyName("idTypeEchantillons")]
    public IEnumerable<int>? IdTypeEchantillons { get; set; } = new HashSet<int>();
    [JsonPropertyName("typeTravauxTypeEchantillons")]
    public ICollection<TypeTravauxTypeEchantillonDto>? TypeTravauxTypeEchantillons { get; set; } = new List<TypeTravauxTypeEchantillonDto>();


}
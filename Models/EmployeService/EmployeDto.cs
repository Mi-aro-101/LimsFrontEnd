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
            result = Departement.Designation;
        }
        return result;
    }

    public HistoriqueEmployeDto GetLastPoste()
    {
        HistoriqueEmployeDto result = new HistoriqueEmployeDto();
        if(this.HistoriqueEmployes != null)
        {
            if(this.HistoriqueEmployes.Count > 0)
            {
                int lastIndex = this.HistoriqueEmployes.Count - 1;
                result = this.HistoriqueEmployes.ElementAt(lastIndex);
            }
        }

        return result;
    }

    [JsonPropertyName("idEmploye")]
    public int IdEmploye { get; set; }
    [JsonPropertyName("matricule")]
    public string? Matricule { get; set; } = "EMP0008";
    [JsonPropertyName("nom")]
    public string? Nom { get; set; } = "RAKOTOARISOA";
    [JsonPropertyName("prenom")]
    public string? Prenom { get; set; } = "Yoan";
    [JsonPropertyName("genre")]
    public int Genre { get; set; } = 0;
    [JsonPropertyName("cin")]
    public string? Cin { get; set; } = "101021024888";
    [JsonPropertyName("contact")]
    public string? Contact { get; set; } = "0349862251";
    [JsonPropertyName("adresse")]
    public string? Adresse { get; set; } = "Lot IPA 23 bis Anjanahary";
    [JsonPropertyName("manager")]
    public string? Manager { get; set; }
    [JsonPropertyName("idDepartement")]
    public int? IdDepartement { get; set; } = 4;
    [JsonPropertyName("departement")]
    public DepartementDto? Departement { get; set; }
    [JsonPropertyName("idPoste")] 
    public int IdPoste { get; set; } = 4;
    [JsonPropertyName("poste")]
    public PosteDto? Poste { get; set; }
    [JsonIgnore]
    public DateOnly? _dateNouveauPoste = DateOnly.FromDateTime(DateTime.Now);
    [JsonIgnore]
    public DateOnly? _dateFinPoste;
    [JsonPropertyName("dateNouveauPoste")]
    public DateOnly? DateNouveauPoste { 
        get => _dateNouveauPoste;
        set {
            if(value > DateOnly.FromDateTime(DateTime.Now)){
                throw new ArgumentException("Date de nouveau poste ne peut pas être dans le futur.");
            }
            if(_dateFinPoste != null){
                if(value < _dateFinPoste.Value){
                    throw new ArgumentException("Date de fin de poste ne peut pas être antérieure à la date de début de poste.");
                }
            }
            _dateNouveauPoste = value;
        }
    }
    [JsonPropertyName("dateFinAncienPoste")]
    public DateOnly? DateFinPoste { 
        get => _dateFinPoste;
        set {
            if(value != null || this.GetLastPoste() != null){
                if(value < this.GetLastPoste().DateDebut) {
                    throw new ArgumentException("Date de fin de poste ne peut pas être antérieure à la date de début de poste.");
                }
            }
            _dateFinPoste = value;
        }
    }

    [JsonPropertyName("statut")]
    public int Statut { get; set; } = 0;
    [JsonPropertyName("historiqueEmployes")]
    public ICollection<HistoriqueEmployeDto> HistoriqueEmployes { get; set; } = new List<HistoriqueEmployeDto>();

}
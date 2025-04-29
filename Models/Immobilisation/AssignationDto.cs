using System.Text.Json.Serialization;

namespace LimsFrontEnd.Models.Immobilisation
{
    public class AssignationDto
    {
       [JsonPropertyName("idAssignation")]
        public int? IdAssignation { get; set; }

        [JsonPropertyName("dateAssignation")]
        public DateTime DateAssignation { get; set; }

        [JsonPropertyName("idLocalisation")]
        public int? IdLocalisation { get; set; }

        [JsonPropertyName("idImmobilisationPropre")]
        public int IdImmobilisationPropre { get; set; }

        [JsonPropertyName("idEmploye")]
        public int IdEmploye { get; set; }

        [JsonPropertyName("localisation")]
        public LocalisationDto? Localisation { get; set; }

        [JsonPropertyName("immobilisationImmatriculation")]
        public ImmobilisationImmatriculationDto? ImmobilisationImmatriculation { get; set; }

        [JsonPropertyName("employe")]
        public EmployeImmobilisationDto? Employe { get; set; } // Modification ici
    }
}